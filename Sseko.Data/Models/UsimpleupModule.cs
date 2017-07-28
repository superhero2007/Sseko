using System;

namespace Sseko.Data.Models
{
    public partial class UsimpleupModule
    {
        public int ModuleId { get; set; }
        public string DownloadUri { get; set; }
        public DateTime? LastChecked { get; set; }
        public DateTime? LastDownloaded { get; set; }
        public string LastStability { get; set; }
        public string LastVersion { get; set; }
        public string LicenseKey { get; set; }
        public string ModuleName { get; set; }
        public string RemoteVersion { get; set; }
    }
}
