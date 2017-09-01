using Akka.Actor;
using Sseko.Akka.DataService.Magento.Actors;
using Sseko.Data;

namespace Sseko.Akka.DataService.Magento
{
    public class Startup
    {
        public static void StartActorSystem(ActorSystem system)
        {
            ActorSystemRefs.System = system;

            ActorSystemRefs.ReportCoordinatorActor = system.ActorOf(
                Props.Create(() => new CoordinatorActor("reportWorkers", 1, 20)),
                ActorSystemRefs.ReportCoordinatorActorName);

            ActorSystemRefs.Context = new SsekoContext();
        }
    }
}
