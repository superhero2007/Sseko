using System;

namespace Sseko.Data.Models
{
    public partial class SpringbotRedirectOrder
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int OrderId { get; set; }
        public int RedirectEntityId { get; set; }
    }
}
