using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SpringbotRedirect
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public string Email { get; set; }
        public int? QuoteId { get; set; }
        public string RedirectId { get; set; }
    }
}
