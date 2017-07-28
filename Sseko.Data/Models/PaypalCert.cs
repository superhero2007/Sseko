using System;

namespace Sseko.Data.Models
{
    public partial class PaypalCert
    {
        public ushort CertId { get; set; }
        public string Content { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CoreWebsite Website { get; set; }
    }
}
