using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class RatingOptionVoteAggregated
    {
        public int PrimaryId { get; set; }
        public ulong EntityPkValue { get; set; }
        public short Percent { get; set; }
        public short? PercentApproved { get; set; }
        public ushort RatingId { get; set; }
        public ushort StoreId { get; set; }
        public int VoteCount { get; set; }
        public int VoteValueSum { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
