using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class NewsletterQueueLink
    {
        public int QueueLinkId { get; set; }
        public DateTime? LetterSentAt { get; set; }
        public int QueueId { get; set; }
        public int SubscriberId { get; set; }

        public virtual NewsletterQueue Queue { get; set; }
        public virtual NewsletterSubscriber Subscriber { get; set; }
    }
}
