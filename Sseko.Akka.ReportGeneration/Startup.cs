using Akka.Actor;
using Sseko.Akka.ReportGeneration.Actors;
using Sseko.Data;

namespace Sseko.Akka.ReportGeneration
{
    public class Startup
    {
        public static void StartActorSystem(ActorSystem system)
        {
            ActorSystemRefs.System = system;

            ActorSystemRefs.ReportCoordinatorActor = system.ActorOf(
                Props.Create(() => new ReportCoordinatorActor("reportWorkers", 1, 20)),
                ActorSystemRefs.ReportCoordinatorActorName);

            ActorSystemRefs.Context = new SsekoContext();
        }
    }
}
