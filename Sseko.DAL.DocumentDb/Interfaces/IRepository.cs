using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Sseko.DAL.DocumentDb.QueryModels;

namespace Sseko.DAL.DocumentDb.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        Task<ResultList<T>> AddAllAsync(List<T> documents);

        Task<Result<T>> AddAsync(T document, RequestOptions requestOptions = null);

        Task<Result<T>> DeleteAsync(T document, RequestOptions requestOptions = null, bool forceDelete = false);

        Task<ResultList<T>> GetAllAsync(FeedOptions feedOptions = null, bool includeDeleted = false);

        Task<Result<T>> GetAsync(string id, FeedOptions feedOptions = null);

        Task<Result<T>> GetAsync(Expression<Func<T, bool>> predicate, FeedOptions feedOptions = null);

        Task<ResultList<T>> GetWhereAsync(Expression<Func<T, bool>> predicate, FeedOptions feedOptions = null, bool includeDeleted = false);

        Task<ResultList<T>> GetWhereWithPagingAsync(Expression<Func<T, bool>> predicate, int itemCount = 10, string continuationToken = "", FeedOptions feedOptions = null, bool includeDeleted = false);

        Task<Result<T>> UpsertAsync(T document, RequestOptions requestOptions = null);
    }
}