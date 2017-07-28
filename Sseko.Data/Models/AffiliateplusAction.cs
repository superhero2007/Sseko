using System;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusAction
    {
        public ulong ActionId { get; set; }
        public string AccountEmail { get; set; }
        public int AccountId { get; set; }
        public int? BannerId { get; set; }
        public string BannerTitle { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int DirectLink { get; set; }
        public string Domain { get; set; }
        public string IpAddress { get; set; }
        public int IsCommission { get; set; }
        public bool IsUnique { get; set; }
        public string LandingPage { get; set; }
        public string Referer { get; set; }
        public ushort StoreId { get; set; }
        public long Totals { get; set; }
        public bool Type { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
