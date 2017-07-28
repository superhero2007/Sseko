namespace Sseko.Data.Models
{
    public partial class LogVisitorInfo
    {
        public ulong VisitorId { get; set; }
        public string HttpAcceptCharset { get; set; }
        public string HttpAcceptLanguage { get; set; }
        public string HttpReferer { get; set; }
        public string HttpUserAgent { get; set; }
        public byte[] RemoteAddr { get; set; }
        public byte[] ServerAddr { get; set; }
    }
}
