using System;

namespace Sseko.Data.Models
{
    public partial class SalesInvoicedAggregated
    {
        public int Id { get; set; }
        public decimal? Invoiced { get; set; }
        public decimal? InvoicedCaptured { get; set; }
        public decimal? InvoicedNotCaptured { get; set; }
        public string OrderStatus { get; set; }
        public int OrdersCount { get; set; }
        public decimal? OrdersInvoiced { get; set; }
        public DateTime? Period { get; set; }
        public ushort? StoreId { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
