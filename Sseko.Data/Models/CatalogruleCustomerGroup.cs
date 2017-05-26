using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogruleCustomerGroup
    {
        public int RuleId { get; set; }
        public ushort CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual Catalogrule Rule { get; set; }
    }
}
