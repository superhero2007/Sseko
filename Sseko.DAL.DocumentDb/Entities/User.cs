using System;
using AspNetCore.Identity.DocumentDb;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Interfaces;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class User : DocumentDbIdentityUser
    {
        public User()
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }

        [JsonProperty(PropertyName = "customerUrlId")]
        public string CustomUrlId { get; set; }

        [JsonProperty(PropertyName = "magentoAccountId")]
        public int MagentoAccountId { get; set; }
    }
}
