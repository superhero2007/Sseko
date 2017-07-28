namespace Sseko.Data.Models
{
    public partial class CataloginventoryStockStatus
    {
        public int ProductId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort StockId { get; set; }
        public decimal Qty { get; set; }
        public ushort StockStatus { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CataloginventoryStock Stock { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
