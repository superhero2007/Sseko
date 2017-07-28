using Newtonsoft.Json;
using System.Collections.Generic;
using System.Security.Claims;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentDbIdentityRole : DocumentBase
    {
        public DocumentDbIdentityRole()
        {
            this.Claims = new List<Claim>();
            this.PKey = "Role";
            this.DocumentType = "DocumentDbIdentityRole";
        }

        [JsonProperty(PropertyName = "pKey")]
        public string PKey { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "normalizedName")]
        public string NormalizedName { get; set; }

        [JsonProperty(PropertyName = "claims")]
        public IList<Claim> Claims { get; set; }
    }
}
