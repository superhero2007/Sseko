using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class IndexProcessEvent
    {
        public int ProcessId { get; set; }
        public ulong EventId { get; set; }
        public string Status { get; set; }

        public virtual IndexEvent Event { get; set; }
        public virtual IndexProcess Process { get; set; }
    }
}
