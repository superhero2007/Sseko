namespace Sseko.Data.Models
{
    public partial class PromotionalgiftCatalogProduct
    {
        public int RuleProductId { get; set; }
        public int ProductId { get; set; }
        public int RuleId { get; set; }

        public virtual PromotionalgiftCatalogRule Rule { get; set; }
    }
}
