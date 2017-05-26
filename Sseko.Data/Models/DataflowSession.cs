using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DataflowSession
    {
        public DataflowSession()
        {
            DataflowImportData = new HashSet<DataflowImportData>();
        }

        public int SessionId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Direction { get; set; }
        public string File { get; set; }
        public string Type { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<DataflowImportData> DataflowImportData { get; set; }
    }
}
