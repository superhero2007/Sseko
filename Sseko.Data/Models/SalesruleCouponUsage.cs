namespace Sseko.Data.Models
{
    public partial class SalesruleCouponUsage
    {
        public int CouponId { get; set; }
        public int CustomerId { get; set; }
        public int TimesUsed { get; set; }

        public virtual SalesruleCoupon Coupon { get; set; }
        public virtual CustomerEntity Customer { get; set; }
    }
}
