using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PromotionalgiftBanner
    {
        public int BannerId { get; set; }
        public string BannerCalendar { get; set; }
        public string Cmsblock { get; set; }
        public string ConditionsSerialized { get; set; }
        public string CustomerGroupIds { get; set; }
        public string Daily { get; set; }
        public DateTime? FromDate { get; set; }
        public int? IsCart { get; set; }
        public int? IsOnepage { get; set; }
        public string Monthly { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public short Status { get; set; }
        public int? TimeUsed { get; set; }
        public DateTime? ToDate { get; set; }
        public string WebsiteIds { get; set; }
        public string Weekly { get; set; }
        public string Yearly { get; set; }
    }
}
