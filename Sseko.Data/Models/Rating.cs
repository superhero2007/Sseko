using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Rating
    {
        public Rating()
        {
            RatingOption = new HashSet<RatingOption>();
            RatingOptionVoteAggregated = new HashSet<RatingOptionVoteAggregated>();
            RatingStore = new HashSet<RatingStore>();
            RatingTitle = new HashSet<RatingTitle>();
        }

        public ushort RatingId { get; set; }
        public ushort EntityId { get; set; }
        public ushort Position { get; set; }
        public string RatingCode { get; set; }

        public virtual ICollection<RatingOption> RatingOption { get; set; }
        public virtual ICollection<RatingOptionVoteAggregated> RatingOptionVoteAggregated { get; set; }
        public virtual ICollection<RatingStore> RatingStore { get; set; }
        public virtual ICollection<RatingTitle> RatingTitle { get; set; }
        public virtual RatingEntity Entity { get; set; }
    }
}
