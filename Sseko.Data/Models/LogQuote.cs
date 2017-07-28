using System;

namespace Sseko.Data.Models
{
    public partial class LogQuote
    {
        public int QuoteId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ulong? VisitorId { get; set; }
    }
}
