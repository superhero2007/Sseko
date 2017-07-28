using System;

namespace Sseko.Data.Models
{
    public partial class UsimplelicLicense
    {
        public int LicenseId { get; set; }
        public DateTime? LastChecked { get; set; }
        public string LastError { get; set; }
        public string LastStatus { get; set; }
        public DateTime? LicenseExpire { get; set; }
        public string LicenseKey { get; set; }
        public string LicenseStatus { get; set; }
        public string Products { get; set; }
        public sbyte? RetryNum { get; set; }
        public string ServerRestriction { get; set; }
        public string Signature { get; set; }
        public DateTime? UpgradeExpire { get; set; }
    }
}
