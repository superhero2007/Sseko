using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class XtentoTrackingimportSource
    {
        public int SourceId { get; set; }
        public string ArchivePath { get; set; }
        public string CustomClass { get; set; }
        public string CustomFunction { get; set; }
        public int DeleteImportedFiles { get; set; }
        public string FilenamePattern { get; set; }
        public int FtpPasv { get; set; }
        public string Hostname { get; set; }
        public DateTime LastModification { get; set; }
        public int LastResult { get; set; }
        public string LastResultMessage { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public int? Port { get; set; }
        public int Timeout { get; set; }
        public string Type { get; set; }
        public string Username { get; set; }
    }
}
