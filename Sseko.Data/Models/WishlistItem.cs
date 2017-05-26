using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class WishlistItem
    {
        public WishlistItem()
        {
            WishlistItemOption = new HashSet<WishlistItemOption>();
        }

        public int WishlistItemId { get; set; }
        public DateTime? AddedAt { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public decimal Qty { get; set; }
        public ushort? StoreId { get; set; }
        public int WishlistId { get; set; }

        public virtual ICollection<WishlistItemOption> WishlistItemOption { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
        public virtual Wishlist Wishlist { get; set; }
    }
}
