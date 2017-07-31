using System;
using Akka.Actor;
using Sseko.Akka.DataService.Actors;
using Sseko.DAL.DocumentDb;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService
{
    public class Startup
    {
        public static void StartActorSystem(ActorSystem system)
        {
            ActorSystemRefs.System = system;

            ActorSystemRefs.UserCoordinatorActor = system.ActorOf(
                Props.Create(() => new CoordinatorActor<User>("userworkers", 1, 20, TimeSpan.FromMinutes(60), 30)),
                ActorSystemRefs.UserCoordinatorName);

            ActorSystemRefs.RoleCoordinatorActor = system.ActorOf(
                Props.Create(() => new CoordinatorActor<Role>("roleWorkers", 1, 20, TimeSpan.FromMinutes(60), 30)),
                ActorSystemRefs.RoleCoordinatorName);

            ActorSystemRefs.DataContext = new DataContext();
        }
    }
}