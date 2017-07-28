using Akka.Actor;
using Sseko.Data;

namespace Sseko.Akka.ReportGeneration
{
    public static class ActorSystemRefs
    {
        public const string ReportCoordinatorActorName = "reportActor";

        public static ActorSystem System;

        public static SsekoContext Context { get; set; }

        public static IActorRef ReportCoordinatorActor { get; internal set; }
    }
}
