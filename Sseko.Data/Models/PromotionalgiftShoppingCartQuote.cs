namespace Sseko.Data.Models
{
    public partial class PromotionalgiftShoppingCartQuote
    {
        public int ShoppingcartQuoteId { get; set; }
        public string CouponCode { get; set; }
        public int GroupedId { get; set; }
        public int ItemId { get; set; }
        public string Message { get; set; }
        public int? Qty { get; set; }
        public int QuoteId { get; set; }
        public int ShoppingcartruleId { get; set; }
    }
}
