using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavAttributeOption
    {
        public EavAttributeOption()
        {
            EavAttributeOptionValue = new HashSet<EavAttributeOptionValue>();
            ZeonManufacturer = new HashSet<ZeonManufacturer>();
        }

        public int OptionId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort SortOrder { get; set; }

        public virtual ICollection<EavAttributeOptionValue> EavAttributeOptionValue { get; set; }
        public virtual ICollection<ZeonManufacturer> ZeonManufacturer { get; set; }
        public virtual EavAttribute Attribute { get; set; }
    }
}
