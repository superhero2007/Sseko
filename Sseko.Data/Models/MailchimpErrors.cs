using System;

namespace Sseko.Data.Models
{
    public partial class MailchimpErrors
    {
        public int Id { get; set; }
        public string BatchId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Errors { get; set; }
        public int? OriginalId { get; set; }
        public string Regtype { get; set; }
        public int? Status { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
}
