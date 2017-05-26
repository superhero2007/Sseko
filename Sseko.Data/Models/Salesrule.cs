using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Salesrule
    {
        public Salesrule()
        {
            SalesruleCoupon = new HashSet<SalesruleCoupon>();
            SalesruleCustomer = new HashSet<SalesruleCustomer>();
            SalesruleCustomerGroup = new HashSet<SalesruleCustomerGroup>();
            SalesruleLabel = new HashSet<SalesruleLabel>();
            SalesruleProductAttribute = new HashSet<SalesruleProductAttribute>();
            SalesruleWebsite = new HashSet<SalesruleWebsite>();
        }

        public int RuleId { get; set; }
        public string ActionsSerialized { get; set; }
        public ushort ApplyToShipping { get; set; }
        public string ConditionsSerialized { get; set; }
        public ushort CouponType { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? DiscountQty { get; set; }
        public int DiscountStep { get; set; }
        public DateTime? FromDate { get; set; }
        public short IsActive { get; set; }
        public ushort IsAdvanced { get; set; }
        public short IsRss { get; set; }
        public short IsUseGiftcard { get; set; }
        public string Name { get; set; }
        public string ProductIds { get; set; }
        public string SimpleAction { get; set; }
        public ushort SimpleFreeShipping { get; set; }
        public int SortOrder { get; set; }
        public short StopRulesProcessing { get; set; }
        public int TimesUsed { get; set; }
        public DateTime? ToDate { get; set; }
        public short UseAutoGeneration { get; set; }
        public int UsesPerCoupon { get; set; }
        public int UsesPerCustomer { get; set; }

        public virtual ICollection<SalesruleCoupon> SalesruleCoupon { get; set; }
        public virtual ICollection<SalesruleCustomer> SalesruleCustomer { get; set; }
        public virtual ICollection<SalesruleCustomerGroup> SalesruleCustomerGroup { get; set; }
        public virtual ICollection<SalesruleLabel> SalesruleLabel { get; set; }
        public virtual ICollection<SalesruleProductAttribute> SalesruleProductAttribute { get; set; }
        public virtual ICollection<SalesruleWebsite> SalesruleWebsite { get; set; }
    }
}
