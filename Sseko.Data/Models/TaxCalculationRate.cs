using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TaxCalculationRate
    {
        public TaxCalculationRate()
        {
            TaxCalculation = new HashSet<TaxCalculation>();
            TaxCalculationRateTitle = new HashSet<TaxCalculationRateTitle>();
        }

        public int TaxCalculationRateId { get; set; }
        public string Code { get; set; }
        public decimal Rate { get; set; }
        public string TaxCountryId { get; set; }
        public string TaxPostcode { get; set; }
        public int TaxRegionId { get; set; }
        public int? ZipFrom { get; set; }
        public short? ZipIsRange { get; set; }
        public int? ZipTo { get; set; }

        public virtual ICollection<TaxCalculation> TaxCalculation { get; set; }
        public virtual ICollection<TaxCalculationRateTitle> TaxCalculationRateTitle { get; set; }
    }
}
