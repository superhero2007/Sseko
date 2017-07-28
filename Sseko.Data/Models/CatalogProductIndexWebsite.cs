using System;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexWebsite
    {
        public ushort WebsiteId { get; set; }
        public float? Rate { get; set; }
        public DateTime? WebsiteDate { get; set; }

        public virtual CoreWebsite Website { get; set; }
    }
}
