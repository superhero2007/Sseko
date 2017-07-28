namespace Sseko.Data.Models
{
    public partial class MailchimpSyncBatches
    {
        public int Id { get; set; }
        public string BatchId { get; set; }
        public string Status { get; set; }
        public string StoreId { get; set; }
    }
}
