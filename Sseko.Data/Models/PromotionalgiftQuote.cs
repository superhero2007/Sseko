namespace Sseko.Data.Models
{
    public partial class PromotionalgiftQuote
    {
        public int PromotionalgiftQuoteId { get; set; }
        public int CatalogRuleId { get; set; }
        public int GroupedId { get; set; }
        public int ItemId { get; set; }
        public int ItemParentId { get; set; }
        public string Message { get; set; }
        public int? NumberItemFree { get; set; }
        public int? Qty { get; set; }
        public int QuoteId { get; set; }
        public int ShoppingCartRuleId { get; set; }
    }
}
