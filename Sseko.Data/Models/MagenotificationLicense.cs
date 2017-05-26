using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MagenotificationLicense
    {
        public int LicenseId { get; set; }
        public DateTime ActiveAt { get; set; }
        public string Domains { get; set; }
        public string ExtensionCode { get; set; }
        public bool? IsValid { get; set; }
        public string LicenseKey { get; set; }
        public short? ResponseCode { get; set; }
        public string SumCode { get; set; }
    }
}
