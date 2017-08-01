using System;
using System.Collections.Generic;
using System.Text;
using Sseko.Akka.DataService.Base;
using Sseko.Core.Enums;
using Sseko.DAL.DocumentDb;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService.Services
{
    public class UserDataService : ServiceBase<User>
    {
        public UserDataService()
        {
            Coordinator = ActorSystemRefs.UserCoordinatorActor;
            Repository = new Repository<User>(ActorSystemRefs.DataContext, DocumentType.DocumentDbIdentityUser);
        }
    }
}
