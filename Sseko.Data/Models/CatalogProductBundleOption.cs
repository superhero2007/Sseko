using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductBundleOption
    {
        public CatalogProductBundleOption()
        {
            CatalogProductBundleOptionValue = new HashSet<CatalogProductBundleOptionValue>();
            CatalogProductBundleSelection = new HashSet<CatalogProductBundleSelection>();
        }

        public int OptionId { get; set; }
        public int ParentId { get; set; }
        public int Position { get; set; }
        public ushort Required { get; set; }
        public string Type { get; set; }

        public virtual ICollection<CatalogProductBundleOptionValue> CatalogProductBundleOptionValue { get; set; }
        public virtual ICollection<CatalogProductBundleSelection> CatalogProductBundleSelection { get; set; }
        public virtual CatalogProductEntity Parent { get; set; }
    }
}
