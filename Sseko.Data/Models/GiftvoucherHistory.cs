using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftvoucherHistory
    {
        public int HistoryId { get; set; }
        public short Action { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Balance { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Currency { get; set; }
        public string CustomerEmail { get; set; }
        public int? CustomerId { get; set; }
        public string ExtraContent { get; set; }
        public int GiftvoucherId { get; set; }
        public decimal? OrderAmount { get; set; }
        public string OrderIncrementId { get; set; }
        public int? OrderItemId { get; set; }
        public short Status { get; set; }

        public virtual Giftvoucher Giftvoucher { get; set; }
    }
}
