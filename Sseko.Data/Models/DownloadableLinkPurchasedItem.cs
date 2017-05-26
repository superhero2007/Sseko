using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DownloadableLinkPurchasedItem
    {
        public int ItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort IsShareable { get; set; }
        public string LinkFile { get; set; }
        public string LinkHash { get; set; }
        public int LinkId { get; set; }
        public string LinkTitle { get; set; }
        public string LinkType { get; set; }
        public string LinkUrl { get; set; }
        public int NumberOfDownloadsBought { get; set; }
        public int NumberOfDownloadsUsed { get; set; }
        public int? OrderItemId { get; set; }
        public int? ProductId { get; set; }
        public int PurchasedId { get; set; }
        public string Status { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual SalesFlatOrderItem OrderItem { get; set; }
        public virtual DownloadableLinkPurchased Purchased { get; set; }
    }
}
