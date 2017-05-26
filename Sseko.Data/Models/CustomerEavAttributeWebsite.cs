using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerEavAttributeWebsite
    {
        public ushort AttributeId { get; set; }
        public ushort WebsiteId { get; set; }
        public string DefaultValue { get; set; }
        public ushort? IsRequired { get; set; }
        public ushort? IsVisible { get; set; }
        public ushort? MultilineCount { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
