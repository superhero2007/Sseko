namespace Sseko.Data.Models
{
    public partial class CatalogProductBundleStockIndex
    {
        public int EntityId { get; set; }
        public ushort WebsiteId { get; set; }
        public ushort StockId { get; set; }
        public int OptionId { get; set; }
        public short? StockStatus { get; set; }
    }
}
