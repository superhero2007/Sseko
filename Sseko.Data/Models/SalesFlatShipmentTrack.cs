using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatShipmentTrack
    {
        public int EntityId { get; set; }
        public string CarrierCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public int ParentId { get; set; }
        public decimal? Qty { get; set; }
        public string Title { get; set; }
        public string TrackNumber { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? Weight { get; set; }

        public virtual SalesFlatShipment Parent { get; set; }
    }
}
