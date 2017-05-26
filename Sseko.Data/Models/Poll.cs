using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Poll
    {
        public Poll()
        {
            PollAnswer = new HashSet<PollAnswer>();
            PollStore = new HashSet<PollStore>();
        }

        public int PollId { get; set; }
        public short Active { get; set; }
        public short? AnswersDisplay { get; set; }
        public short Closed { get; set; }
        public DateTime? DateClosed { get; set; }
        public DateTime DatePosted { get; set; }
        public string PollTitle { get; set; }
        public ushort StoreId { get; set; }
        public int VotesCount { get; set; }

        public virtual ICollection<PollAnswer> PollAnswer { get; set; }
        public virtual ICollection<PollStore> PollStore { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
