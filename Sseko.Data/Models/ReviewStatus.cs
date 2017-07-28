using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ReviewStatus
    {
        public ReviewStatus()
        {
            Review = new HashSet<Review>();
        }

        public ushort StatusId { get; set; }
        public string StatusCode { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}
