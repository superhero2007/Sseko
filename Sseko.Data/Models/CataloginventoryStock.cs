using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CataloginventoryStock
    {
        public CataloginventoryStock()
        {
            CataloginventoryStockItem = new HashSet<CataloginventoryStockItem>();
            CataloginventoryStockStatus = new HashSet<CataloginventoryStockStatus>();
        }

        public ushort StockId { get; set; }
        public string StockName { get; set; }

        public virtual ICollection<CataloginventoryStockItem> CataloginventoryStockItem { get; set; }
        public virtual ICollection<CataloginventoryStockStatus> CataloginventoryStockStatus { get; set; }
    }
}
