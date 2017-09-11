using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sseko.Web.Models
{
    public class UserForImpersonationDto
    {
        [JsonProperty(PropertyName = "userImpersonatingId")]
        public string UserImpersonatingId { get; set; }

        [JsonProperty(PropertyName = "userToImpersonateId")]
        public string UserToImpersonateId { get; set; }
    }
}
