using System;

namespace Sseko.Data.Models
{
    public partial class OauthToken
    {
        public int EntityId { get; set; }
        public int? AdminId { get; set; }
        public ushort Authorized { get; set; }
        public string CallbackUrl { get; set; }
        public int ConsumerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public ushort Revoked { get; set; }
        public string Secret { get; set; }
        public string Token { get; set; }
        public string Type { get; set; }
        public string Verifier { get; set; }

        public virtual AdminUser Admin { get; set; }
        public virtual OauthConsumer Consumer { get; set; }
        public virtual CustomerEntity Customer { get; set; }
    }
}
