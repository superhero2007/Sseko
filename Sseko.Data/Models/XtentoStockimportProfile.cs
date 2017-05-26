using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XtentoStockimportProfile
    {
        public int ProfileId { get; set; }
        public string Configuration { get; set; }
        public string CronjobCustomFrequency { get; set; }
        public int CronjobEnabled { get; set; }
        public string CronjobFrequency { get; set; }
        public int Enabled { get; set; }
        public string Entity { get; set; }
        public DateTime? LastExecution { get; set; }
        public DateTime? LastModification { get; set; }
        public string Name { get; set; }
        public string Processor { get; set; }
        public string SourceIds { get; set; }
    }
}
