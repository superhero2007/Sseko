namespace Sseko.Data.Models
{
    public partial class NewsletterProblem
    {
        public int ProblemId { get; set; }
        public int? ProblemErrorCode { get; set; }
        public string ProblemErrorText { get; set; }
        public int QueueId { get; set; }
        public int? SubscriberId { get; set; }

        public virtual NewsletterQueue Queue { get; set; }
        public virtual NewsletterSubscriber Subscriber { get; set; }
    }
}
