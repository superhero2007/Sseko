using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusCoupon
    {
        public int CouponId { get; set; }
        public int? AccountId { get; set; }
        public string AccountName { get; set; }
        public string CouponCode { get; set; }
        public int? ProgramId { get; set; }
        public string ProgramName { get; set; }
    }
}
