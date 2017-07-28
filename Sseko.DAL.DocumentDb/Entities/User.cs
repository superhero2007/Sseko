using System;
using AspNetCore.Identity.DocumentDb;
using Newtonsoft.Json;

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

        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public DateTime Modified { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "customerUrlId")]
        public string CustomUrlId { get; set; }

        [JsonProperty(PropertyName = "magentoAccountId")]
        public int MagentoAccountId { get; set; }
    }
}
