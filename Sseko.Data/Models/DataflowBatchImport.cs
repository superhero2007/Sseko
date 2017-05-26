using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DataflowBatchImport
    {
        public ulong BatchImportId { get; set; }
        public string BatchData { get; set; }
        public int BatchId { get; set; }
        public ushort Status { get; set; }

        public virtual DataflowBatch Batch { get; set; }
    }
}
