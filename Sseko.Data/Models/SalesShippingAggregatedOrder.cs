using System;

namespace Sseko.Data.Models
{
    public partial class SalesShippingAggregatedOrder
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public int OrdersCount { get; set; }
        public DateTime? Period { get; set; }
        public string ShippingDescription { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? TotalShipping { get; set; }
        public decimal? TotalShippingActual { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
