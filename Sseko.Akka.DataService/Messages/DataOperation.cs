using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Azure.Documents.Client;
using Sseko.DAL.DocumentDb.Interfaces;

namespace Sseko.Akka.DataService.Messages
{
    public abstract class DataOperations
    {
        public enum OperationType
        {
            Get,
            GetAll,
            Upsert,
            Create,
            Delete,
            Query,
            QueryPaged
        }

        public interface IOperation<out T>
        {
            bool CanCache { get; }
            string Id { get; }
            OperationType OperationType { get; }
            Type Type { get; }
            T Document { get; }
        }

        public class Operation<T> : IOperation<T>
        {
            public Operation(IRepository<T> repository, OperationType operationType, bool canCache,
                T document = default(T), string id = "",
                Expression<Func<T, bool>> predicate = null, FeedOptions feedOptions = null,
                RequestOptions requestOptions = null, bool includeDeleted = false,
                int itemCount = 10, string continuationToken = "", bool clearCache = false)
            {
                CanCache = canCache;
                ContinuationToken = continuationToken;
                Document = document;
                FeedOptions = feedOptions;
                Id = id;
                IncludeDeleted = includeDeleted;
                ItemCount = itemCount;
                OperationType = operationType;
                Predicate = predicate;
                Repository = repository;
                RequestOptions = requestOptions;
                Type = typeof(T);
                ClearCache = clearCache;

                if (canCache && string.IsNullOrEmpty(id))
                    throw new ArgumentException("Id must be supplied to use CanCache");

                    // Do a validation check if this document inherits from IDocument
                    if (document != null && document is IDocument)
                        throw new InvalidOperationException("Document does not inherit from IDocument!");

            }

            public bool CanCache { get; }
            public string ContinuationToken { get; }
            public T Document { get; }
            public FeedOptions FeedOptions { get; }
            public string Id { get; }
            public bool IncludeDeleted { get; }
            public int ItemCount { get; }
            public OperationType OperationType { get; }
            public Expression<Func<T, bool>> Predicate { get; }
            public IRepository<T> Repository { get; }
            public RequestOptions RequestOptions { get; }
            public Type Type { get; }
            public bool ClearCache { get; }
        }

        public class Result<T> : DAL.DocumentDb.QueryModels.Result<T>
        {
            public Result()
            {
            }

            public Result(T output, Exception exception = null, string continuationToken = "", double? requestCharge = null, bool fromCache = false)
            {
                Exception = exception;
                Output = output;
                ContinuationToken = continuationToken;
                RequestCharge = requestCharge;
                FromCache = fromCache;
            }

            public Result(DAL.DocumentDb.QueryModels.Result<T> input)
            {
                Exception = input.Exception;
                Output = input.Output;
                ContinuationToken = input.ContinuationToken;
                RequestCharge = input.RequestCharge;
            }

            public bool FromCache { get; internal set; }
        }

        public class ResultList<T> : DAL.DocumentDb.QueryModels.ResultList<T>
        {
            public ResultList()
            {
            }

            public ResultList(List<T> output, Exception exception = null, string continuationToken = "", double? requestCharge = null, bool fromCache = false)
            {
                Exception = exception;
                Output = output;
                ContinuationToken = continuationToken;
                RequestCharge = requestCharge;
                FromCache = fromCache;
            }

            public ResultList(DAL.DocumentDb.QueryModels.ResultList<T> input)
            {
                Exception = input.Exception;
                Output = input.Output;
                ContinuationToken = input.ContinuationToken;
                RequestCharge = input.RequestCharge;
            }

            public bool FromCache { get; internal set; }
        }

        internal class DeleteCache
        {
            internal DeleteCache(string id)
            {
                Id = id;
            }

            internal string Id { get; }
        }

        internal class UpdateCache<T>
        {
            internal UpdateCache(T data, DateTime lastRead, string id)
            {
                Data = data;
                LastRead = lastRead;
                Id = id;
            }

            internal T Data { get; }
            internal string Id { get; }
            internal DateTime LastRead { get; }
        }
    }
}