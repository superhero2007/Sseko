using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ReviewEntity
    {
        public ReviewEntity()
        {
            Review = new HashSet<Review>();
        }

        public ushort EntityId { get; set; }
        public string EntityCode { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}
