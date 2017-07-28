namespace Sseko.Data.Models
{
    public partial class TaxCalculation
    {
        public int TaxCalculationId { get; set; }
        public short CustomerTaxClassId { get; set; }
        public short ProductTaxClassId { get; set; }
        public int TaxCalculationRateId { get; set; }
        public int TaxCalculationRuleId { get; set; }

        public virtual TaxClass CustomerTaxClass { get; set; }
        public virtual TaxClass ProductTaxClass { get; set; }
        public virtual TaxCalculationRate TaxCalculationRate { get; set; }
        public virtual TaxCalculationRule TaxCalculationRule { get; set; }
    }
}
