using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class IndexProcess
    {
        public IndexProcess()
        {
            IndexProcessEvent = new HashSet<IndexProcessEvent>();
        }

        public int ProcessId { get; set; }
        public DateTime? EndedAt { get; set; }
        public string IndexerCode { get; set; }
        public string Mode { get; set; }
        public DateTime? StartedAt { get; set; }
        public string Status { get; set; }

        public virtual ICollection<IndexProcessEvent> IndexProcessEvent { get; set; }
    }
}
