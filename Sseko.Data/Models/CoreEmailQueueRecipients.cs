using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreEmailQueueRecipients
    {
        public int RecipientId { get; set; }
        public short EmailType { get; set; }
        public int MessageId { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }

        public virtual CoreEmailQueue Message { get; set; }
    }
}
