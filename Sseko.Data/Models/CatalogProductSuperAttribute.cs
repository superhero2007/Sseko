using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductSuperAttribute
    {
        public CatalogProductSuperAttribute()
        {
            CatalogProductSuperAttributeLabel = new HashSet<CatalogProductSuperAttributeLabel>();
            CatalogProductSuperAttributePricing = new HashSet<CatalogProductSuperAttributePricing>();
        }

        public int ProductSuperAttributeId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort Position { get; set; }
        public int ProductId { get; set; }

        public virtual ICollection<CatalogProductSuperAttributeLabel> CatalogProductSuperAttributeLabel { get; set; }
        public virtual ICollection<CatalogProductSuperAttributePricing> CatalogProductSuperAttributePricing { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
