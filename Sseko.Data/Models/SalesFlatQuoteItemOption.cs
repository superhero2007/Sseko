namespace Sseko.Data.Models
{
    public partial class SalesFlatQuoteItemOption
    {
        public int OptionId { get; set; }
        public string Code { get; set; }
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }

        public virtual SalesFlatQuoteItem Item { get; set; }
    }
}
