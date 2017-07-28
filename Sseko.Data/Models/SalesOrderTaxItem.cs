namespace Sseko.Data.Models
{
    public partial class SalesOrderTaxItem
    {
        public int TaxItemId { get; set; }
        public int ItemId { get; set; }
        public int TaxId { get; set; }
        public decimal TaxPercent { get; set; }

        public virtual SalesFlatOrderItem Item { get; set; }
        public virtual SalesOrderTax Tax { get; set; }
    }
}
