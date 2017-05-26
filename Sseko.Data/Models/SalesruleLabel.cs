using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesruleLabel
    {
        public int LabelId { get; set; }
        public string Label { get; set; }
        public int RuleId { get; set; }
        public ushort StoreId { get; set; }

        public virtual Salesrule Rule { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
