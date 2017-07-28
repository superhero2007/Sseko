using System;

namespace Sseko.Data.Models
{
    public partial class PromotionalgiftSale
    {
        public int SaleId { get; set; }
        public string CatalogruleId { get; set; }
        public string CouponCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal? GiftTotal { get; set; }
        public int OrderId { get; set; }
        public string OrderIncrementId { get; set; }
        public string OrderStatus { get; set; }
        public decimal? OrderTotal { get; set; }
        public string ProductIds { get; set; }
        public string ProductNames { get; set; }
        public string ShoppingcartruleId { get; set; }
    }
}
