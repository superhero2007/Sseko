using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TinyCompressimagesTotals
    {
        public int EntityId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int TotalBytesAfter { get; set; }
        public int TotalBytesBefore { get; set; }
        public int TotalCompressions { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
