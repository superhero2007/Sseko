using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatShipmentItem
    {
        public int EntityId { get; set; }
        public string AdditionalData { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int? OrderItemId { get; set; }
        public int ParentId { get; set; }
        public decimal? Price { get; set; }
        public int? ProductId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? RowTotal { get; set; }
        public string Sku { get; set; }
        public decimal? Weight { get; set; }

        public virtual SalesFlatShipment Parent { get; set; }
    }
}
