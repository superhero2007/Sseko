using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavAttributeLabel
    {
        public int AttributeLabelId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
