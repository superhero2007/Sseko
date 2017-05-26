using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaOfflineOrder
    {
        public MRmaOfflineOrder()
        {
            MRmaOfflineItem = new HashSet<MRmaOfflineItem>();
        }

        public int OfflineOrderId { get; set; }
        public int? CustomerId { get; set; }
        public string ReceiptNumber { get; set; }

        public virtual ICollection<MRmaOfflineItem> MRmaOfflineItem { get; set; }
        public virtual CustomerEntity Customer { get; set; }
    }
}
