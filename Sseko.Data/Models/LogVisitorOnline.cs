using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class LogVisitorOnline
    {
        public ulong VisitorId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? FirstVisitAt { get; set; }
        public string LastUrl { get; set; }
        public DateTime? LastVisitAt { get; set; }
        public byte[] RemoteAddr { get; set; }
        public string VisitorType { get; set; }
    }
}
