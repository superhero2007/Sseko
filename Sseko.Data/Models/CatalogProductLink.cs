using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductLink
    {
        public CatalogProductLink()
        {
            CatalogProductLinkAttributeDecimal = new HashSet<CatalogProductLinkAttributeDecimal>();
            CatalogProductLinkAttributeInt = new HashSet<CatalogProductLinkAttributeInt>();
            CatalogProductLinkAttributeVarchar = new HashSet<CatalogProductLinkAttributeVarchar>();
        }

        public int LinkId { get; set; }
        public ushort LinkTypeId { get; set; }
        public int LinkedProductId { get; set; }
        public int ProductId { get; set; }

        public virtual ICollection<CatalogProductLinkAttributeDecimal> CatalogProductLinkAttributeDecimal { get; set; }
        public virtual ICollection<CatalogProductLinkAttributeInt> CatalogProductLinkAttributeInt { get; set; }
        public virtual ICollection<CatalogProductLinkAttributeVarchar> CatalogProductLinkAttributeVarchar { get; set; }
        public virtual CatalogProductLinkType LinkType { get; set; }
        public virtual CatalogProductEntity LinkedProduct { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
