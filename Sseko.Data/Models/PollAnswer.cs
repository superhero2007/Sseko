using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PollAnswer
    {
        public PollAnswer()
        {
            PollVote = new HashSet<PollVote>();
        }

        public int AnswerId { get; set; }
        public short AnswerOrder { get; set; }
        public string AnswerTitle { get; set; }
        public int PollId { get; set; }
        public int VotesCount { get; set; }

        public virtual ICollection<PollVote> PollVote { get; set; }
        public virtual Poll Poll { get; set; }
    }
}
