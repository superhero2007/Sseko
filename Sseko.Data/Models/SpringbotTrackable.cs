using System;

namespace Sseko.Data.Models
{
    public partial class SpringbotTrackable
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string Email { get; set; }
        public int? OrderId { get; set; }
        public int? QuoteId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
