using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Affiliateplusprogram
    {
        public Affiliateplusprogram()
        {
            AffiliateplusprogramAccount = new HashSet<AffiliateplusprogramAccount>();
            AffiliateplusprogramCategory = new HashSet<AffiliateplusprogramCategory>();
            AffiliateplusprogramJoined = new HashSet<AffiliateplusprogramJoined>();
            AffiliateplusprogramProduct = new HashSet<AffiliateplusprogramProduct>();
            AffiliateplusprogramValue = new HashSet<AffiliateplusprogramValue>();
        }

        public int ProgramId { get; set; }
        public string ActionsSerialized { get; set; }
        public string AffiliateType { get; set; }
        public bool Autojoin { get; set; }
        public decimal Commission { get; set; }
        public string CommissionType { get; set; }
        public string ConditionsSerialized { get; set; }
        public string CouponPattern { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CustomerGroupIds { get; set; }
        public string CustomerGroups { get; set; }
        public string Description { get; set; }
        public decimal Discount { get; set; }
        public string DiscountType { get; set; }
        public short ExpireTime { get; set; }
        public bool IsProcess { get; set; }
        public int MaxLevel { get; set; }
        public string Name { get; set; }
        public int NumAccount { get; set; }
        public int? Priority { get; set; }
        public bool Scope { get; set; }
        public bool SecCommission { get; set; }
        public string SecCommissionType { get; set; }
        public bool SecDiscount { get; set; }
        public string SecDiscountType { get; set; }
        public string SecTierCommission { get; set; }
        public decimal SecondaryCommission { get; set; }
        public decimal SecondaryDiscount { get; set; }
        public bool ShowInWelcome { get; set; }
        public bool Status { get; set; }
        public string TierCommission { get; set; }
        public decimal TotalSalesAmount { get; set; }
        public bool UseCoupon { get; set; }
        public bool UseSecTier { get; set; }
        public bool UseTierConfig { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public virtual ICollection<AffiliateplusprogramAccount> AffiliateplusprogramAccount { get; set; }
        public virtual ICollection<AffiliateplusprogramCategory> AffiliateplusprogramCategory { get; set; }
        public virtual ICollection<AffiliateplusprogramJoined> AffiliateplusprogramJoined { get; set; }
        public virtual ICollection<AffiliateplusprogramProduct> AffiliateplusprogramProduct { get; set; }
        public virtual ICollection<AffiliateplusprogramValue> AffiliateplusprogramValue { get; set; }
    }
}
