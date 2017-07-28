using System;

namespace Sseko.Data.Models
{
    public partial class XtentoOrderexportLog
    {
        public int LogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string DestinationIds { get; set; }
        public string ExportEvent { get; set; }
        public int ExportType { get; set; }
        public string Files { get; set; }
        public int ProfileId { get; set; }
        public int RecordsExported { get; set; }
        public int Result { get; set; }
        public string ResultMessage { get; set; }
    }
}
