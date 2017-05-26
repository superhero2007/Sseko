using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusReferer
    {
        public AffiliateplusReferer()
        {
            Affiliateplusstatistic = new HashSet<Affiliateplusstatistic>();
        }

        public int RefererId { get; set; }
        public int AccountId { get; set; }
        public string IpList { get; set; }
        public string Referer { get; set; }
        public ushort StoreId { get; set; }
        public int TotalClicks { get; set; }
        public int UniqueClicks { get; set; }
        public string UrlPath { get; set; }

        public virtual ICollection<Affiliateplusstatistic> Affiliateplusstatistic { get; set; }
        public virtual AffiliateplusAccount Account { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
