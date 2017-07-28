using System;

namespace Sseko.Data.Models
{
    public partial class MagenotificationLog
    {
        public int LogId { get; set; }
        public DateTime CheckDate { get; set; }
        public string ExpiredTime { get; set; }
        public string ExtensionCode { get; set; }
        public bool? IsValid { get; set; }
        public string LicenseKey { get; set; }
        public string LicenseType { get; set; }
        public short? ResponseCode { get; set; }
        public string SumCode { get; set; }
    }
}
