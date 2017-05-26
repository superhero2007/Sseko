using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CouponAggregatedUpdated
    {
        public int Id { get; set; }
        public string CouponCode { get; set; }
        public int CouponUses { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountAmountActual { get; set; }
        public string OrderStatus { get; set; }
        public DateTime Period { get; set; }
        public string RuleName { get; set; }
        public ushort? StoreId { get; set; }
        public decimal SubtotalAmount { get; set; }
        public decimal SubtotalAmountActual { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalAmountActual { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
