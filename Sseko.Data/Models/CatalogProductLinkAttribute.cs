using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductLinkAttribute
    {
        public CatalogProductLinkAttribute()
        {
            CatalogProductLinkAttributeDecimal = new HashSet<CatalogProductLinkAttributeDecimal>();
            CatalogProductLinkAttributeInt = new HashSet<CatalogProductLinkAttributeInt>();
            CatalogProductLinkAttributeVarchar = new HashSet<CatalogProductLinkAttributeVarchar>();
        }

        public ushort ProductLinkAttributeId { get; set; }
        public string DataType { get; set; }
        public ushort LinkTypeId { get; set; }
        public string ProductLinkAttributeCode { get; set; }

        public virtual ICollection<CatalogProductLinkAttributeDecimal> CatalogProductLinkAttributeDecimal { get; set; }
        public virtual ICollection<CatalogProductLinkAttributeInt> CatalogProductLinkAttributeInt { get; set; }
        public virtual ICollection<CatalogProductLinkAttributeVarchar> CatalogProductLinkAttributeVarchar { get; set; }
        public virtual CatalogProductLinkType LinkType { get; set; }
    }
}
