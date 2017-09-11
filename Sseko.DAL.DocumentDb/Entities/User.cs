using System;
using Newtonsoft.Json;
using Sseko.Core.Base;
using Sseko.Core.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class User : DocumentBase
    {
        public User(): base(DocumentType.User)
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }

        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }

        [JsonProperty(PropertyName = "securityStamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty(PropertyName = "passwordResetDetails")]
        public PasswordResetDetails PasswordResetDetails { get; set; }

        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        [JsonProperty(PropertyName = "customerUrlId")]
        public string CustomUrlId { get; set; }

        [JsonProperty(PropertyName = "magentoAccountId")]
        public int MagentoAccountId { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }
    }
}
