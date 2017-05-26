using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatShipment
    {
        public SalesFlatShipment()
        {
            SalesFlatShipmentComment = new HashSet<SalesFlatShipmentComment>();
            SalesFlatShipmentItem = new HashSet<SalesFlatShipmentItem>();
            SalesFlatShipmentTrack = new HashSet<SalesFlatShipmentTrack>();
        }

        public int EntityId { get; set; }
        public int? BillingAddressId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public ushort? EmailSent { get; set; }
        public string IncrementId { get; set; }
        public int OrderId { get; set; }
        public string Packages { get; set; }
        public int? ShipmentStatus { get; set; }
        public int? ShippingAddressId { get; set; }
        public byte[] ShippingLabel { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? TotalWeight { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<SalesFlatShipmentComment> SalesFlatShipmentComment { get; set; }
        public virtual SalesFlatShipmentGrid SalesFlatShipmentGrid { get; set; }
        public virtual ICollection<SalesFlatShipmentItem> SalesFlatShipmentItem { get; set; }
        public virtual ICollection<SalesFlatShipmentTrack> SalesFlatShipmentTrack { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
