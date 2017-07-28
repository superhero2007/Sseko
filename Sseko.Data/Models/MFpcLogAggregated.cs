using System;

namespace Sseko.Data.Models
{
    public partial class MFpcLogAggregated
    {
        public int Id { get; set; }
        public int FromCache { get; set; }
        public int Hits { get; set; }
        public DateTime Period { get; set; }
        public decimal ResponseTime { get; set; }
    }
}
