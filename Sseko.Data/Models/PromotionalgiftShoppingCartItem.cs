namespace Sseko.Data.Models
{
    public partial class PromotionalgiftShoppingCartItem
    {
        public int ItemId { get; set; }
        public string GiftQty { get; set; }
        public string ProductIds { get; set; }
        public int RuleId { get; set; }

        public virtual PromotionalgiftShoppingCartRule Rule { get; set; }
    }
}
