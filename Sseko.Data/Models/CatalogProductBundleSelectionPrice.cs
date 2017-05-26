using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductBundleSelectionPrice
    {
        public int SelectionId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort SelectionPriceType { get; set; }
        public decimal SelectionPriceValue { get; set; }

        public virtual CatalogProductBundleSelection Selection { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
