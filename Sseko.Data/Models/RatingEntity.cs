using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class RatingEntity
    {
        public RatingEntity()
        {
            Rating = new HashSet<Rating>();
        }

        public ushort EntityId { get; set; }
        public string EntityCode { get; set; }

        public virtual ICollection<Rating> Rating { get; set; }
    }
}
