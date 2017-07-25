using Akka.Actor;
using Sseko.DAL.DocumentDb;

namespace Sseko.Akka.DataService
{
    public static class ActorSystemRefs
    {
        public const string UserCoordinatorName = "dsUser";
        public const string RoleCoordinatorName = "dsRole";

        public static DataContext DataContext { get; set; }

        public static ActorSystem System;

        public static IActorRef UserCoordinatorActor { get; internal set; }
        public static IActorRef RoleCoordinatorActor { get; internal set; }
    }
}