using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TaxClass
    {
        public TaxClass()
        {
            TaxCalculationCustomerTaxClass = new HashSet<TaxCalculation>();
            TaxCalculationProductTaxClass = new HashSet<TaxCalculation>();
        }

        public short ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassType { get; set; }

        public virtual ICollection<TaxCalculation> TaxCalculationCustomerTaxClass { get; set; }
        public virtual ICollection<TaxCalculation> TaxCalculationProductTaxClass { get; set; }
    }
}
