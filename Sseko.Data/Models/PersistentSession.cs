using System;

namespace Sseko.Data.Models
{
    public partial class PersistentSession
    {
        public int PersistentId { get; set; }
        public int? CustomerId { get; set; }
        public string Info { get; set; }
        public string Key { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
