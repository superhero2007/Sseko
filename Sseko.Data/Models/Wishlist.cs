using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Wishlist
    {
        public Wishlist()
        {
            WishlistItem = new HashSet<WishlistItem>();
        }

        public int WishlistId { get; set; }
        public int CustomerId { get; set; }
        public ushort Shared { get; set; }
        public string SharingCode { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
        public virtual CustomerEntity Customer { get; set; }
    }
}
