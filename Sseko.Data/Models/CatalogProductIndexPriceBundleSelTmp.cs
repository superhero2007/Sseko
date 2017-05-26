using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexPriceBundleSelTmp
    {
        public int EntityId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }
        public int OptionId { get; set; }
        public int SelectionId { get; set; }
        public decimal? GroupPrice { get; set; }
        public ushort? GroupType { get; set; }
        public ushort? IsRequired { get; set; }
        public decimal? Price { get; set; }
        public decimal? TierPrice { get; set; }
    }
}
