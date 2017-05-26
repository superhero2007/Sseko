using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class LogCustomer
    {
        public int LogId { get; set; }
        public int CustomerId { get; set; }
        public DateTime LoginAt { get; set; }
        public DateTime? LogoutAt { get; set; }
        public ushort StoreId { get; set; }
        public ulong? VisitorId { get; set; }
    }
}
