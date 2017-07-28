using System;

namespace Sseko.Data.Models
{
    public partial class DataflowProfileHistory
    {
        public int HistoryId { get; set; }
        public string ActionCode { get; set; }
        public DateTime? PerformedAt { get; set; }
        public int ProfileId { get; set; }
        public int UserId { get; set; }

        public virtual DataflowProfile Profile { get; set; }
    }
}
