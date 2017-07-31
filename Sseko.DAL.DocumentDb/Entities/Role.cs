using System;
using AspNetCore.Identity.DocumentDb;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Interfaces;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class Role : DocumentDbIdentityRole
    {
        public Role()
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }
    }
}
