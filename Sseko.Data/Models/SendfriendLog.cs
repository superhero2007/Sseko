namespace Sseko.Data.Models
{
    public partial class SendfriendLog
    {
        public int LogId { get; set; }
        public byte[] Ip { get; set; }
        public int Time { get; set; }
        public ushort WebsiteId { get; set; }
    }
}
