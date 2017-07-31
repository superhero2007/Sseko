using System;
using System.Collections.Generic;
using System.Text;
using Sseko.Akka.DataService.Base;
using Sseko.Core.Enums;
using Sseko.DAL.DocumentDb;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.DataService.Services
{
    public class RoleDataService : ServiceBase<Role>
    {
        public RoleDataService()
        {
            Coordinator = ActorSystemRefs.RoleCoordinatorActor;
            Repository = new Repository<Role>(ActorSystemRefs.DataContext, DocumentType.DocumentDbIdentityRole);
        }
    }
}
