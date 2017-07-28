using System;

namespace Sseko.Data.Models
{
    public partial class PollVote
    {
        public int VoteId { get; set; }
        public int? CustomerId { get; set; }
        public byte[] IpAddress { get; set; }
        public int PollAnswerId { get; set; }
        public int PollId { get; set; }
        public DateTime? VoteTime { get; set; }

        public virtual PollAnswer PollAnswer { get; set; }
    }
}
