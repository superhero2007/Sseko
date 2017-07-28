using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatShipmentGrid
    {
        public int EntityId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string IncrementId { get; set; }
        public DateTime? OrderCreatedAt { get; set; }
        public int OrderId { get; set; }
        public string OrderIncrementId { get; set; }
        public int? ShipmentStatus { get; set; }
        public string ShippingName { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? TotalQty { get; set; }

        public virtual SalesFlatShipment Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
