using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XtentoOrderexportProfileHistory
    {
        public int HistoryId { get; set; }
        public string Entity { get; set; }
        public int EntityId { get; set; }
        public DateTime ExportedAt { get; set; }
        public int LogId { get; set; }
        public int ProfileId { get; set; }
    }
}
