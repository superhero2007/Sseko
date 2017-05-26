using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerFormAttribute
    {
        public string FormCode { get; set; }
        public ushort AttributeId { get; set; }

        public virtual EavAttribute Attribute { get; set; }
    }
}
