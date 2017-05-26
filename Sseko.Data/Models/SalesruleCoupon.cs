using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesruleCoupon
    {
        public SalesruleCoupon()
        {
            SalesruleCouponUsage = new HashSet<SalesruleCouponUsage>();
        }

        public int CouponId { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public ushort? IsPrimary { get; set; }
        public int RuleId { get; set; }
        public int TimesUsed { get; set; }
        public short? Type { get; set; }
        public int? UsageLimit { get; set; }
        public int? UsagePerCustomer { get; set; }

        public virtual ICollection<SalesruleCouponUsage> SalesruleCouponUsage { get; set; }
        public virtual Salesrule Rule { get; set; }
    }
}
