using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductSuperAttributePricing
    {
        public int ValueId { get; set; }
        public ushort? IsPercent { get; set; }
        public decimal? PricingValue { get; set; }
        public int ProductSuperAttributeId { get; set; }
        public string ValueIndex { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CatalogProductSuperAttribute ProductSuperAttribute { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
