using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CataloginventoryStockStatusTmp
    {
        public int ProductId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort StockId { get; set; }
        public decimal Qty { get; set; }
        public ushort StockStatus { get; set; }
    }
}
