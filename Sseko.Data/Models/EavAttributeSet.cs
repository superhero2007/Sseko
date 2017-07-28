using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavAttributeSet
    {
        public EavAttributeSet()
        {
            CatalogProductEntity = new HashSet<CatalogProductEntity>();
            EavAttributeGroup = new HashSet<EavAttributeGroup>();
        }

        public ushort AttributeSetId { get; set; }
        public string AttributeSetName { get; set; }
        public ushort EntityTypeId { get; set; }
        public short SortOrder { get; set; }

        public virtual ICollection<CatalogProductEntity> CatalogProductEntity { get; set; }
        public virtual ICollection<EavAttributeGroup> EavAttributeGroup { get; set; }
        public virtual EavEntityType EntityType { get; set; }
    }
}
