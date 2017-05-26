using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class OauthConsumer
    {
        public OauthConsumer()
        {
            OauthToken = new HashSet<OauthToken>();
        }

        public int EntityId { get; set; }
        public string CallbackUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string RejectedCallbackUrl { get; set; }
        public string Secret { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<OauthToken> OauthToken { get; set; }
    }
}
