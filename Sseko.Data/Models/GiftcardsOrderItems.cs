using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftcardsOrderItems
    {
        public int Id { get; set; }
        public decimal Discount { get; set; }
        public int GiftcardId { get; set; }
        public int OrderId { get; set; }
        public int OrderItemId { get; set; }
        public int QuoteId { get; set; }
        public int QuoteItemId { get; set; }
    }
}
