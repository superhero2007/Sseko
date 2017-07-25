using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.DataService.Messages;

namespace Sseko.Akka.DataService.Actors
{
    public class SessionActor<T> : ReceiveActor, ILogReceive
    {
        private T _cache;
        private string _id;
        private DateTime _lastRead;
        private TimeSpan _receiveTimeout;
        private int _sessionTimeout;

        public SessionActor(string id, TimeSpan receiveTimeout, int sessionTimeout)
        {
            _cache = default(T);
            _id = id;
            _lastRead = DateTime.UtcNow;
            _receiveTimeout = receiveTimeout;
            _sessionTimeout = sessionTimeout;

            SetReceiveTimeout(_receiveTimeout); // Shutdown this Actor if it hasn't been used
            Become(Ready);
        }

        private void Ready()
        {
            Receive<DataOperations.Operation<T>>(message =>
            {
                // If we have a copy of the Firm in memory and
                // we have the correct FirmId for the request and
                // our cached version is not more than X min old
                // then return the cached version
                if (message.ClearCache != true && _cache != null && message.Id == _id &&
                    _lastRead.AddMinutes(_sessionTimeout) > DateTime.UtcNow)
                {
                    Sender.Tell(new DataOperations.Result<T>(_cache, fromCache: true));
                }
                else
                {
                    var senderClosure = Sender;
                    var selfClosure = Self;
                    var operationClosure = message;

                    switch (message.OperationType)
                    {
                        case DataOperations.OperationType.Create:
                            operationClosure.Repository.AddAsync(message.Document, message.RequestOptions).ContinueWith(request =>
                                    {
                                        if (!request.IsFaulted && message.CanCache)
                                            selfClosure.Tell(new DataOperations.UpdateCache<T>(request.Result.Output, DateTime.UtcNow, message.Id));

                                        return new DataOperations.Result<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;

                        case DataOperations.OperationType.Delete:
                            operationClosure.Repository.DeleteAsync(message.Document).ContinueWith(request =>
                                    {
                                        selfClosure.Tell(new DataOperations.DeleteCache(message.Id));

                                        return new DataOperations.Result<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;

                        case DataOperations.OperationType.Get:
                            operationClosure.Repository.GetAsync(message.Id, message.FeedOptions).ContinueWith(request =>
                                    {
                                        if (!request.IsFaulted && message.CanCache)
                                            selfClosure.Tell(new DataOperations.UpdateCache<T>(request.Result.Output, DateTime.UtcNow, message.Id));

                                        return new DataOperations.Result<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;

                        case DataOperations.OperationType.GetAll:
                            operationClosure.Repository.GetAllAsync(message.FeedOptions).ContinueWith(request =>
                                    {
                                        if (!request.IsFaulted && message.CanCache)
                                            selfClosure.Tell(new DataOperations.UpdateCache<List<T>>(request.Result.Output, DateTime.UtcNow, message.Id));

                                        return new DataOperations.ResultList<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;

                        case DataOperations.OperationType.Query:
                            operationClosure.Repository.GetWhereAsync(message.Predicate, message.FeedOptions).ContinueWith(request =>
                                    {
                                        if (!request.IsFaulted && message.CanCache)
                                            selfClosure.Tell(new DataOperations.UpdateCache<List<T>>(request.Result.Output, DateTime.UtcNow, message.Id));

                                        return new DataOperations.ResultList<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;

                        case DataOperations.OperationType.Upsert:
                            operationClosure.Repository.UpsertAsync(message.Document, message.RequestOptions).ContinueWith(request =>
                                    {
                                        if (!request.IsFaulted && message.CanCache)
                                            selfClosure.Tell(new DataOperations.UpdateCache<T>(request.Result.Output, DateTime.UtcNow, message.Id));

                                        return new DataOperations.Result<T>(request.Result);
                                    },
                                    TaskContinuationOptions.AttachedToParent &
                                    TaskContinuationOptions.ExecuteSynchronously)
                                .PipeTo(senderClosure);

                            break;
                    }
                }
            });

            Receive<DataOperations.UpdateCache<T>>(message =>
            {
                if (message.Id == _id)
                {
                    _cache = message.Data;
                    _lastRead = message.LastRead;
                }
            });

            Receive<DataOperations.DeleteCache>(message =>
            {
                if (message.Id == _id)
                {
                    // Deleting the cache on a Session should remove it from memory
                    // Clear the _cache value as a precaution and set the ReceiveTimeout
                    // to 1 second which will force this actor to remove itself and notify
                    // its parent.
                    _cache = default(T);
                    SetReceiveTimeout(TimeSpan.FromSeconds(1));
                }
            });
        }
    }
}