using System.Threading.Tasks;
using Akka.Actor;
using Sseko.Akka.DataService.Messages;

namespace Sseko.Akka.DataService.Actors
{
    public class WorkerActor<T> : ReceiveActor, ILogReceive
    {
        public WorkerActor()
        {
            Receive<DataOperations.Operation<T>>(message =>
            {
                var senderClosure = Sender;
                var selfClosure = Self;
                var operationClosure = message;

                switch (message.OperationType)
                {
                    case DataOperations.OperationType.Create:
                        operationClosure.Repository.AddAsync(message.Document, message.RequestOptions).ContinueWith(request => new DataOperations.Result<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.Delete:
                        operationClosure.Repository.DeleteAsync(message.Document, message.RequestOptions).ContinueWith(request => new DataOperations.Result<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.Get:
                        operationClosure.Repository.GetAsync(message.Id, message.FeedOptions).ContinueWith(request => new DataOperations.Result<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.GetAll:
                        operationClosure.Repository.GetAllAsync(message.FeedOptions, message.IncludeDeleted).ContinueWith(request => new DataOperations.ResultList<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.Query:
                        operationClosure.Repository.GetWhereAsync(message.Predicate, message.FeedOptions, message.IncludeDeleted).ContinueWith(request => new DataOperations.ResultList<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.QueryPaged:
                        operationClosure.Repository.GetWhereWithPagingAsync(message.Predicate, message.ItemCount, message.ContinuationToken, message.FeedOptions, message.IncludeDeleted).ContinueWith(request => new DataOperations.ResultList<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;

                    case DataOperations.OperationType.Upsert:
                        operationClosure.Repository.UpsertAsync(message.Document, message.RequestOptions).ContinueWith(request => new DataOperations.Result<T>(request.Result),
                                TaskContinuationOptions.AttachedToParent &
                                TaskContinuationOptions.ExecuteSynchronously)
                            .PipeTo(senderClosure);

                        break;
                }
            });
        }
    }
}