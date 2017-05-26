using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerAddressEntity
    {
        public CustomerAddressEntity()
        {
            CustomerAddressEntityDatetime = new HashSet<CustomerAddressEntityDatetime>();
            CustomerAddressEntityDecimal = new HashSet<CustomerAddressEntityDecimal>();
            CustomerAddressEntityInt = new HashSet<CustomerAddressEntityInt>();
            CustomerAddressEntityText = new HashSet<CustomerAddressEntityText>();
            CustomerAddressEntityVarchar = new HashSet<CustomerAddressEntityVarchar>();
        }

        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort EntityTypeId { get; set; }
        public string IncrementId { get; set; }
        public ushort IsActive { get; set; }
        public int? ParentId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<CustomerAddressEntityDatetime> CustomerAddressEntityDatetime { get; set; }
        public virtual ICollection<CustomerAddressEntityDecimal> CustomerAddressEntityDecimal { get; set; }
        public virtual ICollection<CustomerAddressEntityInt> CustomerAddressEntityInt { get; set; }
        public virtual ICollection<CustomerAddressEntityText> CustomerAddressEntityText { get; set; }
        public virtual ICollection<CustomerAddressEntityVarchar> CustomerAddressEntityVarchar { get; set; }
        public virtual CustomerEntity Parent { get; set; }
    }
}
