using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavAttributeGroup
    {
        public EavAttributeGroup()
        {
            EavEntityAttribute = new HashSet<EavEntityAttribute>();
        }

        public ushort AttributeGroupId { get; set; }
        public string AttributeGroupName { get; set; }
        public ushort AttributeSetId { get; set; }
        public ushort? DefaultId { get; set; }
        public short SortOrder { get; set; }

        public virtual ICollection<EavEntityAttribute> EavEntityAttribute { get; set; }
        public virtual EavAttributeSet AttributeSet { get; set; }
    }
}
