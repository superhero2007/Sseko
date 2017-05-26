using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TaxCalculationRateTitle
    {
        public int TaxCalculationRateTitleId { get; set; }
        public ushort StoreId { get; set; }
        public int TaxCalculationRateId { get; set; }
        public string Value { get; set; }

        public virtual CoreStore Store { get; set; }
        public virtual TaxCalculationRate TaxCalculationRate { get; set; }
    }
}
