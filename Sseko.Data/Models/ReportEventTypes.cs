using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ReportEventTypes
    {
        public ReportEventTypes()
        {
            ReportEvent = new HashSet<ReportEvent>();
        }

        public ushort EventTypeId { get; set; }
        public ushort CustomerLogin { get; set; }
        public string EventName { get; set; }

        public virtual ICollection<ReportEvent> ReportEvent { get; set; }
    }
}
