namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexPriceFinalTmp
    {
        public int EntityId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }
        public decimal? BaseGroupPrice { get; set; }
        public decimal? BaseTier { get; set; }
        public decimal? GroupPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? OrigPrice { get; set; }
        public decimal? Price { get; set; }
        public ushort? TaxClassId { get; set; }
        public decimal? TierPrice { get; set; }
    }
}
