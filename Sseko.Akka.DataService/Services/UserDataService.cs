using System;
using System.Collections.Generic;
using System.Text;
using Sseko.Akka.DataService.Base;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService.Services
{
    public class UserDataService : ServiceBase<User>
    {
        public UserDataService()
        {
            Coordinator = ActorSystemRefs.UserCoordinatorActor;
        }
    }
}
