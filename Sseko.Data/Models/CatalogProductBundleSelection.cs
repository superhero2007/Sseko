using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductBundleSelection
    {
        public CatalogProductBundleSelection()
        {
            CatalogProductBundleSelectionPrice = new HashSet<CatalogProductBundleSelectionPrice>();
        }

        public int SelectionId { get; set; }
        public ushort IsDefault { get; set; }
        public int OptionId { get; set; }
        public int ParentProductId { get; set; }
        public int Position { get; set; }
        public int ProductId { get; set; }
        public short SelectionCanChangeQty { get; set; }
        public ushort SelectionPriceType { get; set; }
        public decimal SelectionPriceValue { get; set; }
        public decimal? SelectionQty { get; set; }

        public virtual ICollection<CatalogProductBundleSelectionPrice> CatalogProductBundleSelectionPrice { get; set; }
        public virtual CatalogProductBundleOption Option { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
