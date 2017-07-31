using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Akka.Actor;
using AspNetCore.Identity.DocumentDb;
using Sseko.Akka.DataService.Messages;
using Sseko.Core.Interfaces;
using Sseko.DAL.DocumentDb.Interfaces;

namespace Sseko.Akka.DataService.Base
{
    public abstract class ServiceBase<T>
    {
        internal IActorRef Coordinator { get; set; }
        internal IRepository<T> Repository { get; set; }

        public virtual async Task<DataOperations.Result<T>> CreateAsync(T document)
        {
            var entity = (IDocument)document;

            return (DataOperations.Result<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.Create, true, document, entity.Id, clearCache: true))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.Result<T>> DeleteAsync(T document)
        {
            var entity = (IDocument)document;

            return (DataOperations.Result<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.Delete, true, document, entity.Id, clearCache: true))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.ResultList<T>> GetAllAsync(bool includeDeleted = false)
        {
            return (DataOperations.ResultList<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.GetAll, false, includeDeleted: includeDeleted))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.Result<T>> GetAsync(string id, bool clearCache = false)
        {
            return (DataOperations.Result<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.Get, true, id: id, clearCache: clearCache))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.ResultList<T>> GetAsync(Expression<Func<T, bool>> predicate, bool includeDeleted = false)
        {
            return (DataOperations.ResultList<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.Query, false, predicate: predicate, includeDeleted: includeDeleted))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.ResultList<T>> GetWithPagingAsync(Expression<Func<T, bool>> predicate = null, int itemCount = 10, string continuationToken = "", bool includeDeleted = false)
        {
            return (DataOperations.ResultList<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.QueryPaged, false, predicate: predicate, includeDeleted: includeDeleted, itemCount: itemCount, continuationToken: continuationToken))
                .ConfigureAwait(false);
        }

        public virtual async Task<DataOperations.Result<T>> UpsertAsync(T document)
        {
            var entity = (IDocument)document;

            return (DataOperations.Result<T>)await Coordinator
                .Ask(new DataOperations.Operation<T>(Repository, DataOperations.OperationType.Upsert, true, document, entity.Id, clearCache: true))
                .ConfigureAwait(false);
        }
    }
}