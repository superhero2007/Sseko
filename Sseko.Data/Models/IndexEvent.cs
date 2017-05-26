using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class IndexEvent
    {
        public IndexEvent()
        {
            IndexProcessEvent = new HashSet<IndexProcessEvent>();
        }

        public ulong EventId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Entity { get; set; }
        public long? EntityPk { get; set; }
        public string NewData { get; set; }
        public string OldData { get; set; }
        public string Type { get; set; }

        public virtual ICollection<IndexProcessEvent> IndexProcessEvent { get; set; }
    }
}
