using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MFpcLog
    {
        public int LogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int FromCache { get; set; }
        public decimal ResponseTime { get; set; }
    }
}
