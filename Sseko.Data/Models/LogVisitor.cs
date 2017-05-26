using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class LogVisitor
    {
        public ulong VisitorId { get; set; }
        public DateTime? FirstVisitAt { get; set; }
        public ulong LastUrlId { get; set; }
        public DateTime LastVisitAt { get; set; }
        public string SessionId { get; set; }
        public ushort StoreId { get; set; }
    }
}
