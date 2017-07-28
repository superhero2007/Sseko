using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductLinkType
    {
        public CatalogProductLinkType()
        {
            CatalogProductLink = new HashSet<CatalogProductLink>();
            CatalogProductLinkAttribute = new HashSet<CatalogProductLinkAttribute>();
        }

        public ushort LinkTypeId { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CatalogProductLink> CatalogProductLink { get; set; }
        public virtual ICollection<CatalogProductLinkAttribute> CatalogProductLinkAttribute { get; set; }
    }
}
