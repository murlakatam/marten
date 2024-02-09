using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JasperFx.Core;
using JasperFx.Core.Reflection;
using Marten.Events.Daemon.Progress;
using Marten.Events.Projections;
using Marten.Services;
using Microsoft.Extensions.Logging;

namespace Marten.Events.Daemon;

public partial class ProjectionDaemon
{
    public Task RebuildProjection(string projectionName, CancellationToken token)
    {
        return RebuildProjection(projectionName, 5.Minutes(), token);
    }

    public Task RebuildProjection<TView>(CancellationToken token)
    {
        return RebuildProjection<TView>(5.Minutes(), token);
    }

    public Task RebuildProjection(Type projectionType, CancellationToken token)
    {
        return RebuildProjection(projectionType, 5.Minutes(), token);
    }

    public Task RebuildProjection(Type projectionType, TimeSpan shardTimeout, CancellationToken token)
    {
        if (projectionType.CanBeCastTo<IProjection>())
        {
            var projectionName = projectionType.FullNameInCode();
            return RebuildProjection(projectionName, shardTimeout, token);
        }

        if (projectionType.CanBeCastTo<IProjectionSource>())
        {
            try
            {
                var projection = Activator.CreateInstance(projectionType);
                if (projection is IProjectionSource wrapper)
                    return RebuildProjection(wrapper.ProjectionName, shardTimeout, token);

                throw new ArgumentOutOfRangeException(nameof(projectionType),
                    $"Type {projectionType.FullNameInCode()} is not a valid projection type");
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException(nameof(projectionType), e,
                    $"No public default constructor for projection type {projectionType.FullNameInCode()}, you may need to supply the projection name instead");
            }
        }

        // Assume this is an aggregate type name
        return RebuildProjection(projectionType.NameInCode(), shardTimeout, token);
    }

    public Task RebuildProjection(string projectionName, TimeSpan shardTimeout, CancellationToken token)
    {
        if (!_store.Options.Projections.TryFindProjection(projectionName, out var projection))
        {
            throw new ArgumentOutOfRangeException(nameof(projectionName),
                $"No registered projection matches the name '{projectionName}'. Available names are {_store.Options.Projections.AllProjectionNames().Join(", ")}");
        }

        return rebuildProjection(projection, shardTimeout, token);
    }

    public Task RebuildProjection<TView>(TimeSpan shardTimeout, CancellationToken token)
    {
        if (typeof(TView).CanBeCastTo(typeof(ProjectionBase)) && typeof(TView).HasDefaultConstructor())
        {
            var projection = (ProjectionBase)Activator.CreateInstance(typeof(TView))!;
            return RebuildProjection(projection.ProjectionName!, shardTimeout, token);
        }

        return RebuildProjection(typeof(TView).Name, shardTimeout, token);
    }

        // TODO -- ZOMG, this is awful
    private async Task rebuildProjection(IProjectionSource source, TimeSpan shardTimeout, CancellationToken token)
    {
        await Database.EnsureStorageExistsAsync(typeof(IEvent), token).ConfigureAwait(false);

        Logger.LogInformation("Starting to rebuild Projection {ProjectionName}@{DatabaseIdentifier}",
            source.ProjectionName, Database.Identifier);

        var running = _active.Where(x => x.Name.ProjectionName == source.ProjectionName).ToArray();
        foreach (var agent in running)
        {
            await agent.HardStopAsync().ConfigureAwait(false);
            _active.Remove(agent);
        }

        if (token.IsCancellationRequested)
        {
            return;
        }

        await _highWater.CheckNow().ConfigureAwait(false);

        // If there's no data, do nothing
        if (Tracker.HighWaterMark == 0)
        {
            Logger.LogInformation("Aborting projection rebuild because the high water mark is 0 (no event data)");
            return;
        }

        if (token.IsCancellationRequested)
        {
            return;
        }

        var agents = _factory.BuildAgentsForProjection(source.ProjectionName, Database);

        foreach (var agent in agents)
        {
            Tracker.MarkAsRestarted(agent.Name);
        }

        // Teardown the current state
        await teardownExistingProjectionProgress(source, token, agents).ConfigureAwait(false);

        if (token.IsCancellationRequested)
        {
            return;
        }

        var mark = Tracker.HighWaterMark;

        // Is the shard count the optimal DoP here?
        await Parallel.ForEachAsync(agents,
            new ParallelOptions { CancellationToken = token, MaxDegreeOfParallelism = agents.Count },
            async (agent, cancellationToken) =>
            {
                Tracker.MarkAsRestarted(agent.Name);

                await startAgent(agent, ShardExecutionMode.Rebuild).ConfigureAwait(false);

                await Tracker.WaitForShardState(agent.Name, mark, shardTimeout).ConfigureAwait(false);
            }).ConfigureAwait(false);

        foreach (var agent in agents)
        {
            // TODO -- timeout and harden here
            await agent.StopAndDrainAsync(CancellationToken.None).ConfigureAwait(false);
        }
    }


    private async Task teardownExistingProjectionProgress(IProjectionSource source, CancellationToken token,
        IReadOnlyList<ISubscriptionAgent> agents)
    {
        var sessionOptions = SessionOptions.ForDatabase(Database);
        sessionOptions.AllowAnyTenant = true;
        await using var session = _store.LightweightSession(sessionOptions);
        source.Options.Teardown(session);

        foreach (var agent in agents)
        {
            session.QueueOperation(new DeleteProjectionProgress(_store.Events, agent.Name.Identity));
        }

        // Rewind previous DeadLetterEvents because you're going to replay them all anyway
        session.DeleteWhere<DeadLetterEvent>(x => x.ProjectionName == source.ProjectionName);

        await session.SaveChangesAsync(token).ConfigureAwait(false);
    }
}