namespace Sseko.Data.Models
{
    public partial class RatingOptionVote
    {
        public ulong VoteId { get; set; }
        public int? CustomerId { get; set; }
        public ulong EntityPkValue { get; set; }
        public int OptionId { get; set; }
        public short Percent { get; set; }
        public ushort RatingId { get; set; }
        public string RemoteIp { get; set; }
        public byte[] RemoteIpLong { get; set; }
        public ulong? ReviewId { get; set; }
        public short Value { get; set; }

        public virtual RatingOption Option { get; set; }
        public virtual Review Review { get; set; }
    }
}
