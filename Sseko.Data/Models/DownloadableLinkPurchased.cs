using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DownloadableLinkPurchased
    {
        public DownloadableLinkPurchased()
        {
            DownloadableLinkPurchasedItem = new HashSet<DownloadableLinkPurchasedItem>();
        }

        public int PurchasedId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string LinkSectionTitle { get; set; }
        public int? OrderId { get; set; }
        public string OrderIncrementId { get; set; }
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<DownloadableLinkPurchasedItem> DownloadableLinkPurchasedItem { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
    }
}
