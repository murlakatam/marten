// <auto-generated/>
#pragma warning disable
using DocumentDbTests.Bugs;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertDocWithUintOperation1372666391
    public class UpsertDocWithUintOperation1372666391 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertDocWithUintOperation1372666391(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_bug_1256_querying_against_a_uint_type_docwithuint(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertDocWithUintOperation1372666391
    
    
    // START: InsertDocWithUintOperation1372666391
    public class InsertDocWithUintOperation1372666391 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertDocWithUintOperation1372666391(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_bug_1256_querying_against_a_uint_type_docwithuint(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertDocWithUintOperation1372666391
    
    
    // START: UpdateDocWithUintOperation1372666391
    public class UpdateDocWithUintOperation1372666391 : Marten.Internal.Operations.StorageOperation<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateDocWithUintOperation1372666391(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_bug_1256_querying_against_a_uint_type_docwithuint(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateDocWithUintOperation1372666391
    
    
    // START: QueryOnlyDocWithUintSelector1372666391
    public class QueryOnlyDocWithUintSelector1372666391 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyDocWithUintSelector1372666391(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint Resolve(System.Data.Common.DbDataReader reader)
        {

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyDocWithUintSelector1372666391
    
    
    // START: LightweightDocWithUintSelector1372666391
    public class LightweightDocWithUintSelector1372666391 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightDocWithUintSelector1372666391(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightDocWithUintSelector1372666391
    
    
    // START: IdentityMapDocWithUintSelector1372666391
    public class IdentityMapDocWithUintSelector1372666391 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapDocWithUintSelector1372666391(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapDocWithUintSelector1372666391
    
    
    // START: DirtyTrackingDocWithUintSelector1372666391
    public class DirtyTrackingDocWithUintSelector1372666391 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>, Marten.Linq.Selectors.ISelector<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingDocWithUintSelector1372666391(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = _serializer.FromJson<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document;
            document = await _serializer.FromJsonAsync<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingDocWithUintSelector1372666391
    
    
    // START: QueryOnlyDocWithUintDocumentStorage1372666391
    public class QueryOnlyDocWithUintDocumentStorage1372666391 : Marten.Internal.Storage.QueryOnlyDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyDocWithUintDocumentStorage1372666391(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyDocWithUintSelector1372666391(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyDocWithUintDocumentStorage1372666391
    
    
    // START: LightweightDocWithUintDocumentStorage1372666391
    public class LightweightDocWithUintDocumentStorage1372666391 : Marten.Internal.Storage.LightweightDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightDocWithUintDocumentStorage1372666391(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightDocWithUintSelector1372666391(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightDocWithUintDocumentStorage1372666391
    
    
    // START: IdentityMapDocWithUintDocumentStorage1372666391
    public class IdentityMapDocWithUintDocumentStorage1372666391 : Marten.Internal.Storage.IdentityMapDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapDocWithUintDocumentStorage1372666391(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapDocWithUintSelector1372666391(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapDocWithUintDocumentStorage1372666391
    
    
    // START: DirtyTrackingDocWithUintDocumentStorage1372666391
    public class DirtyTrackingDocWithUintDocumentStorage1372666391 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingDocWithUintDocumentStorage1372666391(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertDocWithUintOperation1372666391
            (
                document, Identity(document),
                session.Versions.ForType<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingDocWithUintSelector1372666391(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingDocWithUintDocumentStorage1372666391
    
    
    // START: DocWithUintBulkLoader1372666391
    public class DocWithUintBulkLoader1372666391 : Marten.Internal.CodeGeneration.BulkLoader<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid> _storage;

        public DocWithUintBulkLoader1372666391(Marten.Internal.Storage.IDocumentStorage<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp.\"id\", mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp.\"data\", mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp.\"mt_version\", mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp left join public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint on mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp.id = public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint.id where public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_bug_1256_querying_against_a_uint_type_docwithuint_temp as select * from public.mt_doc_bug_1256_querying_against_a_uint_type_docwithuint limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: DocWithUintBulkLoader1372666391
    
    
    // START: DocWithUintProvider1372666391
    public class DocWithUintProvider1372666391 : Marten.Internal.Storage.DocumentProvider<DocumentDbTests.Bugs.Bug_1256_querying_against_a_uint_type.DocWithUint>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DocWithUintProvider1372666391(Marten.Schema.DocumentMapping mapping) : base(new DocWithUintBulkLoader1372666391(new QueryOnlyDocWithUintDocumentStorage1372666391(mapping)), new QueryOnlyDocWithUintDocumentStorage1372666391(mapping), new LightweightDocWithUintDocumentStorage1372666391(mapping), new IdentityMapDocWithUintDocumentStorage1372666391(mapping), new DirtyTrackingDocWithUintDocumentStorage1372666391(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: DocWithUintProvider1372666391
    
    
}
