using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogruleProductPrice
    {
        public int RuleProductPriceId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public DateTime? EarliestEndDate { get; set; }
        public DateTime? LatestStartDate { get; set; }
        public int ProductId { get; set; }
        public DateTime RuleDate { get; set; }
        public decimal RulePrice { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
