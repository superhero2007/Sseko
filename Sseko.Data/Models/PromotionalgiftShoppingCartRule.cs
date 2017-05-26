using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PromotionalgiftShoppingCartRule
    {
        public PromotionalgiftShoppingCartRule()
        {
            PromotionalgiftShoppingCartItem = new HashSet<PromotionalgiftShoppingCartItem>();
        }

        public int RuleId { get; set; }
        public string ConditionsSerialized { get; set; }
        public string CouponCode { get; set; }
        public short CouponType { get; set; }
        public string CustomerGroupIds { get; set; }
        public string Daily { get; set; }
        public string Description { get; set; }
        public int DiscountProduct { get; set; }
        public int? DiscountProductFixed { get; set; }
        public short FreeShipping { get; set; }
        public DateTime? FromDate { get; set; }
        public string GiftCalendar { get; set; }
        public string Monthly { get; set; }
        public string Name { get; set; }
        public int? NumberItemFree { get; set; }
        public int? PriceType { get; set; }
        public int? Priority { get; set; }
        public bool ShowBeforeDate { get; set; }
        public short Status { get; set; }
        public DateTime? ToDate { get; set; }
        public int? UsesPerCoupon { get; set; }
        public string WebsiteIds { get; set; }
        public string Weekly { get; set; }
        public string Yearly { get; set; }

        public virtual ICollection<PromotionalgiftShoppingCartItem> PromotionalgiftShoppingCartItem { get; set; }
    }
}
