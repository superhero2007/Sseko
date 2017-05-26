using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class RatingOption
    {
        public RatingOption()
        {
            RatingOptionVote = new HashSet<RatingOptionVote>();
        }

        public int OptionId { get; set; }
        public string Code { get; set; }
        public ushort Position { get; set; }
        public ushort RatingId { get; set; }
        public ushort Value { get; set; }

        public virtual ICollection<RatingOptionVote> RatingOptionVote { get; set; }
        public virtual Rating Rating { get; set; }
    }
}
