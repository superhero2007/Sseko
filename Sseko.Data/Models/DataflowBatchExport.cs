namespace Sseko.Data.Models
{
    public partial class DataflowBatchExport
    {
        public ulong BatchExportId { get; set; }
        public string BatchData { get; set; }
        public int BatchId { get; set; }
        public ushort Status { get; set; }

        public virtual DataflowBatch Batch { get; set; }
    }
}
