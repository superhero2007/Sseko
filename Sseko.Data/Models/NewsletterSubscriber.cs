using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class NewsletterSubscriber
    {
        public NewsletterSubscriber()
        {
            NewsletterProblem = new HashSet<NewsletterProblem>();
            NewsletterQueueLink = new HashSet<NewsletterQueueLink>();
        }

        public int SubscriberId { get; set; }
        public DateTime? ChangeStatusAt { get; set; }
        public int CustomerId { get; set; }
        public DateTime MailchimpSyncDelta { get; set; }
        public string MailchimpSyncError { get; set; }
        public ushort? StoreId { get; set; }
        public string SubscriberConfirmCode { get; set; }
        public string SubscriberEmail { get; set; }
        public string SubscriberFirstname { get; set; }
        public string SubscriberLastname { get; set; }
        public int SubscriberStatus { get; set; }

        public virtual ICollection<NewsletterProblem> NewsletterProblem { get; set; }
        public virtual ICollection<NewsletterQueueLink> NewsletterQueueLink { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
