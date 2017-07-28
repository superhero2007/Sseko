namespace Sseko.Data.Models
{
    public partial class NewsletterQueueStoreLink
    {
        public int QueueId { get; set; }
        public ushort StoreId { get; set; }

        public virtual NewsletterQueue Queue { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
