using System;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusTracking
    {
        public int TrackingId { get; set; }
        public int AccountId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerId { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
    }
}
