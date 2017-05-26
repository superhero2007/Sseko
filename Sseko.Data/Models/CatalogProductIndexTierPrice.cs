using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexTierPrice
    {
        public int EntityId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }
        public decimal? MinPrice { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
