using System;
using System.Collections.Generic;
using Akka.Actor;
using Akka.Routing;
using Sseko.Akka.DataService.Messages;

namespace Sseko.Akka.DataService.Actors
{
    public class CoordinatorActor<T> : ReceiveActor, ILogReceive
    {
        private readonly IDictionary<string, IActorRef> _sessions;
        private IActorRef _workers;
        private string _poolName;
        private int _poolMin;
        private int _poolMax;
        private TimeSpan _receiveTimeout;
        private int _sessionTimeout;

        public CoordinatorActor(string poolName, int poolMin, int poolMax, TimeSpan receiveTimeout, int sessionTimeout)
        {
            _poolName = poolName;
            _poolMin = poolMin;
            _poolMax = poolMax;
            _receiveTimeout = receiveTimeout;
            _sessionTimeout = sessionTimeout;
            _sessions = new Dictionary<string, IActorRef>();

            Become(Ready);
        }

        protected override void PreStart()
        {
            // Create a pool of worker actors and
            // set the initial pool size to PoolMin workers.
            // Also create an auto resizer which will auto
            // size the pool from PoolMin to PoolMax workers as needed.
            _workers = Context.ActorOf(Props.Create(() => new WorkerActor<T>())
                    .WithRouter(new RoundRobinPool(_poolMin,
                        new DefaultResizer(_poolMin, _poolMax)))
                , _poolName);
        }

        private IActorRef LookupOrCreateSessionActor(string id)
        {
            var child = Context.Child(id);

            return child.Equals(ActorRefs.Nobody) ? Context.ActorOf(Props.Create(() => new SessionActor<T>(id, _receiveTimeout, _sessionTimeout)), id) : child;
        }

        private void Ready()
        {
            ReceiveAny(message =>
            {
                // Check to make sure this is a data operation
                if (message is DataOperations.IOperation<T> options)
                    if (options.CanCache)
                    {
                        // Lookup or Create a Session Actor to forward this message to
                        var actor = _sessions[options.Id] = LookupOrCreateSessionActor(options.Id);
                        actor.Forward(message);
                    }
                    else
                    {
                        // Forward any other messages to the pool of workers
                        _workers.Forward(message);
                    }
                else
                    throw new NotImplementedException("Message type not supported by CoordinatorActor");
            });
        }
    }
}