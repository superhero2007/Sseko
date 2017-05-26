using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class LogSummary
    {
        public ulong SummaryId { get; set; }
        public DateTime AddDate { get; set; }
        public int CustomerCount { get; set; }
        public ushort StoreId { get; set; }
        public ushort? TypeId { get; set; }
        public int VisitorCount { get; set; }
    }
}
