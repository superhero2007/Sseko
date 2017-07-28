namespace Sseko.Data.Models
{
    public partial class CataloginventoryStockStatusIdx
    {
        public int ProductId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort StockId { get; set; }
        public decimal Qty { get; set; }
        public ushort StockStatus { get; set; }
    }
}
