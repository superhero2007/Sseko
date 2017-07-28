using System;

namespace Sseko.Data.Models
{
    public partial class CustomerAddressEntityDatetime
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public DateTime Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CustomerAddressEntity Entity { get; set; }
        public virtual EavEntityType EntityType { get; set; }
    }
}
