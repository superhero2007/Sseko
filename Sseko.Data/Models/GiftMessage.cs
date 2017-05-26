using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class GiftMessage
    {
        public int GiftMessageId { get; set; }
        public int CustomerId { get; set; }
        public string Message { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
    }
}
