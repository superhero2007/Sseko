using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrderGrid
    {
        public int EntityId { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseGrandTotal { get; set; }
        public decimal? BaseTotalPaid { get; set; }
        public string BillingName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public decimal? GrandTotal { get; set; }
        public string IncrementId { get; set; }
        public string OrderCurrencyCode { get; set; }
        public string ShippingName { get; set; }
        public string Status { get; set; }
        public ushort? StoreId { get; set; }
        public string StoreName { get; set; }
        public decimal? TotalPaid { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual SalesFlatOrder Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
