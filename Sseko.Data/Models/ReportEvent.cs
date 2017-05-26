using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ReportEvent
    {
        public ulong EventId { get; set; }
        public ushort EventTypeId { get; set; }
        public DateTime LoggedAt { get; set; }
        public int ObjectId { get; set; }
        public ushort StoreId { get; set; }
        public int SubjectId { get; set; }
        public ushort Subtype { get; set; }

        public virtual ReportEventTypes EventType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
