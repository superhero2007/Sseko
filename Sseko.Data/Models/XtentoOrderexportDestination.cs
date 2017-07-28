using System;

namespace Sseko.Data.Models
{
    public partial class XtentoOrderexportDestination
    {
        public int DestinationId { get; set; }
        public string CustomClass { get; set; }
        public string CustomFunction { get; set; }
        public int DoRetry { get; set; }
        public int EmailAttachFiles { get; set; }
        public string EmailBody { get; set; }
        public string EmailRecipient { get; set; }
        public string EmailSender { get; set; }
        public string EmailSubject { get; set; }
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
