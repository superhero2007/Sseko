namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexPriceOptAgrIdx
    {
        public int EntityId { get; set; }
        public ushort CustomerGroupId { get; set; }
        public ushort WebsiteId { get; set; }
        public int OptionId { get; set; }
        public decimal? GroupPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? TierPrice { get; set; }
    }
}
