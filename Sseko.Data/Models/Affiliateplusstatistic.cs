using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Affiliateplusstatistic
    {
        public int Id { get; set; }
        public string AccountEmail { get; set; }
        public string IpAddress { get; set; }
        public string Referer { get; set; }
        public int RefererId { get; set; }
        public short StoreId { get; set; }
        public string UrlPath { get; set; }
        public DateTime? VisitAt { get; set; }

        public virtual AffiliateplusReferer RefererNavigation { get; set; }
    }
}
