using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DataflowImportData
    {
        public int ImportId { get; set; }
        public int SerialNumber { get; set; }
        public int? SessionId { get; set; }
        public int Status { get; set; }
        public string Value { get; set; }

        public virtual DataflowSession Session { get; set; }
    }
}
