using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerAddressEntityInt
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public int Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CustomerAddressEntity Entity { get; set; }
        public virtual EavEntityType EntityType { get; set; }
    }
}
