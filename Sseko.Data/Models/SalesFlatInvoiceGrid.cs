using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatInvoiceGrid
    {
        public int EntityId { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseGrandTotal { get; set; }
        public string BillingName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string GlobalCurrencyCode { get; set; }
        public decimal? GrandTotal { get; set; }
        public string IncrementId { get; set; }
        public DateTime? OrderCreatedAt { get; set; }
        public string OrderCurrencyCode { get; set; }
        public int OrderId { get; set; }
        public string OrderIncrementId { get; set; }
        public int? State { get; set; }
        public string StoreCurrencyCode { get; set; }
        public ushort? StoreId { get; set; }

        public virtual SalesFlatInvoice Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
