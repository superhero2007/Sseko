using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class NewsletterQueue
    {
        public NewsletterQueue()
        {
            NewsletterProblem = new HashSet<NewsletterProblem>();
            NewsletterQueueLink = new HashSet<NewsletterQueueLink>();
            NewsletterQueueStoreLink = new HashSet<NewsletterQueueStoreLink>();
        }

        public int QueueId { get; set; }
        public string NewsletterSenderEmail { get; set; }
        public string NewsletterSenderName { get; set; }
        public string NewsletterStyles { get; set; }
        public string NewsletterSubject { get; set; }
        public string NewsletterText { get; set; }
        public int? NewsletterType { get; set; }
        public DateTime? QueueFinishAt { get; set; }
        public DateTime? QueueStartAt { get; set; }
        public int QueueStatus { get; set; }
        public int TemplateId { get; set; }

        public virtual ICollection<NewsletterProblem> NewsletterProblem { get; set; }
        public virtual ICollection<NewsletterQueueLink> NewsletterQueueLink { get; set; }
        public virtual ICollection<NewsletterQueueStoreLink> NewsletterQueueStoreLink { get; set; }
        public virtual NewsletterTemplate Template { get; set; }
    }
}
