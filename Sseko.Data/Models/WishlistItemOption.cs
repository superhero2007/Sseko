namespace Sseko.Data.Models
{
    public partial class WishlistItemOption
    {
        public int OptionId { get; set; }
        public string Code { get; set; }
        public int ProductId { get; set; }
        public string Value { get; set; }
        public int WishlistItemId { get; set; }

        public virtual WishlistItem WishlistItem { get; set; }
    }
}
