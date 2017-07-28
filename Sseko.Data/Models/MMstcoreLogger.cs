using System;

namespace Sseko.Data.Models
{
    public partial class MMstcoreLogger
    {
        public int LogId { get; set; }
        public string Class { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Level { get; set; }
        public string Message { get; set; }
        public string Module { get; set; }
        public string Trace { get; set; }
    }
}
