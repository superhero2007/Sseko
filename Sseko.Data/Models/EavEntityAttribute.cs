using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavEntityAttribute
    {
        public int EntityAttributeId { get; set; }
        public ushort AttributeGroupId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort AttributeSetId { get; set; }
        public ushort EntityTypeId { get; set; }
        public short SortOrder { get; set; }

        public virtual EavAttributeGroup AttributeGroup { get; set; }
        public virtual EavAttribute Attribute { get; set; }
    }
}
