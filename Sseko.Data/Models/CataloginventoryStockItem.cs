using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CataloginventoryStockItem
    {
        public int ItemId { get; set; }
        public ushort Backorders { get; set; }
        public ushort EnableQtyIncrements { get; set; }
        public ushort IsDecimalDivided { get; set; }
        public ushort IsInStock { get; set; }
        public ushort IsQtyDecimal { get; set; }
        public DateTime? LowStockDate { get; set; }
        public ushort ManageStock { get; set; }
        public decimal MaxSaleQty { get; set; }
        public decimal MinQty { get; set; }
        public decimal MinSaleQty { get; set; }
        public decimal? NotifyStockQty { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal QtyIncrements { get; set; }
        public ushort StockId { get; set; }
        public ushort StockStatusChangedAuto { get; set; }
        public ushort UseConfigBackorders { get; set; }
        public ushort UseConfigEnableQtyInc { get; set; }
        public ushort UseConfigManageStock { get; set; }
        public ushort UseConfigMaxSaleQty { get; set; }
        public ushort UseConfigMinQty { get; set; }
        public ushort UseConfigMinSaleQty { get; set; }
        public ushort UseConfigNotifyStockQty { get; set; }
        public ushort UseConfigQtyIncrements { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CataloginventoryStock Stock { get; set; }
    }
}
