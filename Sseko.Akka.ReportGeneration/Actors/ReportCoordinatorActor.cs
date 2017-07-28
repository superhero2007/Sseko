using System;
using Akka.Actor;
using Akka.Routing;
using Sseko.Akka.ReportGeneration.Messages;

namespace Sseko.Akka.ReportGeneration.Actors
{
    public class ReportCoordinatorActor : ReceiveActor, ILogReceive
    {
        private IActorRef _workers;
        private string _poolName;
        private int _poolMin;
        private int _poolMax;

        public ReportCoordinatorActor(string poolName, int poolMin, int poolMax)
        {
            _poolName = poolName;
            _poolMin = poolMin;
            _poolMax = poolMax;

            Become(Ready);
        }

        protected override void PreStart()
        {
            _workers = Context.ActorOf(Props.Create(() => new WorkerActor())
                    .WithRouter(
                                new RoundRobinPool(_poolMin, new DefaultResizer(_poolMin, _poolMax))),
                                _poolName);
        }

        private void Ready()
        {
            ReceiveAny(message =>
            {
                if (message is ReportOperations.IOperation)
                {
                    _workers.Forward(message);
                }
                else
                {
                    throw new NotImplementedException("Message type not supported by ReportCoordintorActor");
                }
            });
        }
    }
}
