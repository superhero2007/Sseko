using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesruleCustomerGroup
    {
        public int RuleId { get; set; }
        public ushort CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Salesrule Rule { get; set; }
    }
}
