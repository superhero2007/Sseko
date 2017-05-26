using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DataflowBatch
    {
        public DataflowBatch()
        {
            DataflowBatchExport = new HashSet<DataflowBatchExport>();
            DataflowBatchImport = new HashSet<DataflowBatchImport>();
        }

        public int BatchId { get; set; }
        public string Adapter { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Params { get; set; }
        public int ProfileId { get; set; }
        public ushort StoreId { get; set; }

        public virtual ICollection<DataflowBatchExport> DataflowBatchExport { get; set; }
        public virtual ICollection<DataflowBatchImport> DataflowBatchImport { get; set; }
        public virtual DataflowProfile Profile { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
