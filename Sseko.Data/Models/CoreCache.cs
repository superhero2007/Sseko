namespace Sseko.Data.Models
{
    public partial class CoreCache
    {
        public string Id { get; set; }
        public int? CreateTime { get; set; }
        public byte[] Data { get; set; }
        public int? ExpireTime { get; set; }
        public int? UpdateTime { get; set; }
    }
}
