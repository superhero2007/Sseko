using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;
using Sseko.Core.Base;
using Sseko.Core.Enums;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentDbIdentityRole : DocumentBase
    {
        public DocumentDbIdentityRole() : base(DocumentType.DocumentDbIdentityRole)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Claims = new List<Claim>();
            this.PKey = "DocumentDbIdentityRole";
            this.DocumentType = DocumentType.DocumentDbIdentityRole;
        }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "normalizedName")]
        public string NormalizedName { get; set; }

        [JsonProperty(PropertyName = "claims")]
        public IList<Claim> Claims { get; set; }
    }
}
