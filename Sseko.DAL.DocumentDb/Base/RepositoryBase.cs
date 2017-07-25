using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Exceptionless;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Interfaces;
using Sseko.DAL.DocumentDb.QueryModels;

namespace Sseko.DAL.DocumentDb.Base
{
    public class RepositoryBase<T> : IRepository<T> where T : DocumentBase
    {
        private Uri _baseUri;
        private DataContext _context;
        private DocumentType _docType;

        /// <summary>Initializes a new instance of the <see cref="RepositoryBase{T}" /> class.</summary>
        public RepositoryBase(DataContext context, DocumentType documentType)
        {
            _context = context;
            _baseUri = UriFactory.CreateDocumentCollectionUri(_context.Database, _context.CollectionName);
            _docType = documentType;
        }

        public virtual Result<T> Add(T document, RequestOptions requestOptions = null)
        {
            return Task.Run(async () => await AddAsync(document, requestOptions).ConfigureAwait(false)).Result;
        }

        /// <summary>Creates all the specified documents.</summary>
        public virtual async Task<ResultList<T>> AddAllAsync(List<T> documents)
        {
            try
            {
                var results = new ResultList<T>
                {
                    Output = new List<T>()
                };

                foreach (var d in documents)
                {
                    var page = await AddAsync(d).ConfigureAwait(false);
                    results.Output.Add(page.Output);
                    results.RequestCharge += page.RequestCharge;
                    if (page.Exception != null) results.Exception = page.Exception;
                }

                return results;
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(documents)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(documents)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    Exception = ex
                };
            }
        }

        public virtual async Task<Result<T>> AddAsync(T document, RequestOptions requestOptions = null)
        {
            try
            {
                var result = await _context.Client.CreateDocumentAsync(_baseUri, document, SetPKey(requestOptions), true).ConfigureAwait(false);
                //T obj = (T)(dynamic)(result).Resource;

                return new Result<T>
                {
                    RequestCharge = result.RequestCharge,
                    Output = (T)(dynamic)result.Resource
                };
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    Exception = ex
                };
            }
        }

        /// <summary>Creates document query using the <see cref="DocumentClient" /></summary>
        private IOrderedQueryable<T> CreateDocumentQuery(FeedOptions feedOptions = null)
        {
            return _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions));
        }

        public virtual async Task<Result<T>> DeleteAsync(T document, RequestOptions requestOptions = null, bool forceDelete = false)
        {
            try
            {
                if (forceDelete)
                {
                    var delete = await _context.Client.DeleteDocumentAsync(document.SelfLink, requestOptions);

                    return new Result<T>
                    {
                        RequestCharge = delete.RequestCharge
                    };
                }
                document.Deleted = true;
                return await UpsertAsync(document, requestOptions).ConfigureAwait(false);
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(forceDelete)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(forceDelete)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    Exception = ex
                };
            }
        }

        public void Dispose()
        {
        }

        /// <summary>Gets all documents in the collection</summary>
        public virtual async Task<ResultList<T>> GetAllAsync(FeedOptions feedOptions = null, bool includeDeleted = false)
        {
            try
            {
                var results = new ResultList<T>
                {
                    Output = new List<T>()
                };

                double totalCost = 0;

                var queryBuilder = includeDeleted ? CreateDocumentQuery(SetPKey(feedOptions)) : CreateDocumentQuery(SetPKey(feedOptions)).Where(q => q.Deleted == false);

                var query = queryBuilder.AsDocumentQuery();

                while (query.HasMoreResults)
                {
                    var page = await query.ExecuteNextAsync<T>().ConfigureAwait(false);
                    results.Output.AddRange(page.AsEnumerable());
                    totalCost += page.RequestCharge;
                }

                results.RequestCharge = totalCost;

                return results;
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    Exception = ex
                };
            }
        }

        /// <summary>Gets a document that meets the specified predicate.</summary>
        public virtual async Task<Result<T>> GetAsync(Expression<Func<T, bool>> predicate, FeedOptions feedOptions = null)
        {
            try
            {
                feedOptions = SetPKey(feedOptions);

                // We are only querying for a single record by ID so set the MaxItemCount for performance
                feedOptions.MaxItemCount = 1;

                double totalCost = 0;

                IQueryable<T> queryBuilder;

                queryBuilder = predicate == null ? _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)) : _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)).Where(predicate);

                var query = queryBuilder.AsDocumentQuery();

                var queryResults = await query.ExecuteNextAsync<T>().ConfigureAwait(false);
                totalCost += queryResults.RequestCharge;

                return new Result<T>
                {
                    RequestCharge = totalCost,
                    Output = queryResults.FirstOrDefault()
                };
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(predicate?.ToString())
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(predicate?.ToString())
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    Exception = ex
                };
            }
        }

        public virtual async Task<Result<T>> GetAsync(string id, FeedOptions feedOptions = null)
        {
            return await GetAsync(d => d.Id == id, feedOptions).ConfigureAwait(false);
        }

        public virtual ResultList<T> GetWhere(Expression<Func<T, bool>> predicate, FeedOptions feedOptions = null, bool includeDeleted = false)
        {
            return Task.Run(async () => await GetWhereAsync(predicate, feedOptions, includeDeleted).ConfigureAwait(false)).Result;
        }

        /// <summary>Gets documents in the collection that meets the predicate</summary>
        public virtual async Task<ResultList<T>> GetWhereAsync(Expression<Func<T, bool>> predicate, FeedOptions feedOptions = null, bool includeDeleted = false)
        {
            try
            {
                var results = new ResultList<T>
                {
                    Output = new List<T>()
                };

                var queryBuilder = includeDeleted ? CreateDocumentQuery(SetPKey(feedOptions)).Where(predicate) : CreateDocumentQuery(SetPKey(feedOptions)).Where(q => q.Deleted == false).Where(predicate);

                var query = queryBuilder.AsDocumentQuery();

                while (query.HasMoreResults)
                {
                    var page = await query.ExecuteNextAsync<T>().ConfigureAwait(false);
                    results.Output.AddRange(page.AsEnumerable());
                    results.RequestCharge += page.RequestCharge;
                }

                return results;
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(predicate?.ToString())
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(feedOptions)
                    .AddObject(predicate?.ToString())
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    Exception = ex
                };
            }
        }

        /// <summary>Gets documents in the collection that meets the predicate with paging</summary>
        public virtual async Task<ResultList<T>> GetWhereWithPagingAsync(Expression<Func<T, bool>> predicate = null, int itemCount = 10, string continuationToken = "", FeedOptions feedOptions = null, bool includeDeleted = false)
        {
            IDocumentQuery<T> query = null;

            try
            {
                var results = new ResultList<T>
                {
                    Output = new List<T>()
                };

                if (feedOptions == null) feedOptions = new FeedOptions();

                feedOptions.MaxItemCount = itemCount;
                feedOptions.RequestContinuation = continuationToken;

                IQueryable<T> queryBuilder;

                if (predicate == null)
                    queryBuilder = includeDeleted ? _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)) : _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)).Where(q => q.Deleted == false);
                else
                    queryBuilder = includeDeleted ? _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)).Where(predicate) : _context.Client.CreateDocumentQuery<T>(_baseUri, SetPKey(feedOptions)).Where(q => q.Deleted == false).Where(predicate);

                query = queryBuilder.AsDocumentQuery();

                var page = await query.ExecuteNextAsync<T>().ConfigureAwait(false);
                results.ContinuationToken = page.ResponseContinuation;
                results.Output.AddRange(page.AsEnumerable());
                results.RequestCharge = page.RequestCharge;

                return results;
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(query?.ToString())
                    .AddObject(predicate?.ToString())
                    .AddObject(itemCount)
                    .AddObject(continuationToken)
                    .AddObject(feedOptions)
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(query?.ToString())
                    .AddObject(predicate?.ToString())
                    .AddObject(itemCount)
                    .AddObject(continuationToken)
                    .AddObject(feedOptions)
                    .AddObject(includeDeleted)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new ResultList<T>
                {
                    Exception = ex
                };
            }
        }

        /// <summary>
        ///     Updates or creates the specified document.
        /// </summary>
        public virtual async Task<Result<T>> UpsertAsync(T document, RequestOptions requestOptions = null)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(document.ETag))
                {
                    // The document we are trying to save already exists
                    // and we have an ETag for it.  Enable version conflict check.

                    if (requestOptions == null) requestOptions = new RequestOptions();
                    requestOptions.AccessCondition = new AccessCondition { Condition = document.ETag, Type = AccessConditionType.IfMatch };
                }

                document.Modified = DateTime.UtcNow;

                var result = await _context.Client.UpsertDocumentAsync(_baseUri, document, SetPKey(requestOptions), true).ConfigureAwait(false);

                return new Result<T>
                {
                    RequestCharge = result.RequestCharge,
                    Output = (T)(dynamic)result.Resource
                };
            }
            catch (DocumentClientException ce)
            {
                ce.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    RequestCharge = ce.RequestCharge,
                    Exception = ce
                };
            }
            catch (Exception ex)
            {
                ex.ToExceptionless()
                    .AddObject(document)
                    .AddObject(requestOptions)
                    .AddObject(_docType.ToString())
                    .Submit();

                return new Result<T>
                {
                    Exception = ex
                };
            }
        }

        /// <summary>Gets the document self link.</summary>
        //protected virtual async Task<string> GetSelfLink(T document)
        //{
        //    return string.IsNullOrWhiteSpace(document.SelfLink)
        //                          ? (await GetAsync(document.Id).ConfigureAwait(false))?.Results.SelfLink
        //                          : document.SelfLink;
        //}

        //private void SetOriginal(T document)
        //{
        //    //ToDo: Figure out how to add diff logging
        //    //string original = JsonConvert.SerializeObject(document);
        //    //document._original = JsonConvert.DeserializeObject<T>(original);
        //}
        private FeedOptions SetPKey(FeedOptions feedOptions)
        {
            var f = feedOptions;

            if (f == null)
                f = new FeedOptions
                {
                    PartitionKey = new PartitionKey(_docType.ToString())
                };
            else if (f.PartitionKey == null)
                f.PartitionKey = new PartitionKey(_docType.ToString());

            return f;
        }

        private RequestOptions SetPKey(RequestOptions requestOptions)
        {
            var f = requestOptions;

            if (f == null)
                f = new RequestOptions
                {
                    PartitionKey = new PartitionKey(_docType.ToString())
                };
            else if (f.PartitionKey == null)
                f.PartitionKey = new PartitionKey(_docType.ToString());

            return f;
        }
    }

}