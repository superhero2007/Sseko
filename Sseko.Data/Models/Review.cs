using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Review
    {
        public Review()
        {
            RatingOptionVote = new HashSet<RatingOptionVote>();
            ReviewDetail = new HashSet<ReviewDetail>();
            ReviewStore = new HashSet<ReviewStore>();
        }

        public ulong ReviewId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort EntityId { get; set; }
        public int EntityPkValue { get; set; }
        public ushort StatusId { get; set; }

        public virtual ICollection<RatingOptionVote> RatingOptionVote { get; set; }
        public virtual ICollection<ReviewDetail> ReviewDetail { get; set; }
        public virtual ICollection<ReviewStore> ReviewStore { get; set; }
        public virtual ReviewEntity Entity { get; set; }
        public virtual ReviewStatus Status { get; set; }
    }
}
