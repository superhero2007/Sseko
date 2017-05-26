using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TaxCalculationRule
    {
        public TaxCalculationRule()
        {
            TaxCalculation = new HashSet<TaxCalculation>();
        }

        public int TaxCalculationRuleId { get; set; }
        public int CalculateSubtotal { get; set; }
        public string Code { get; set; }
        public int Position { get; set; }
        public int Priority { get; set; }

        public virtual ICollection<TaxCalculation> TaxCalculation { get; set; }
    }
}
