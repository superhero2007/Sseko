using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatCreditmemo
    {
        public SalesFlatCreditmemo()
        {
            SalesFlatCreditmemoComment = new HashSet<SalesFlatCreditmemoComment>();
            SalesFlatCreditmemoItem = new HashSet<SalesFlatCreditmemoItem>();
        }

        public int EntityId { get; set; }
        public decimal? Adjustment { get; set; }
        public decimal? AdjustmentNegative { get; set; }
        public decimal? AdjustmentPositive { get; set; }
        public decimal? AffiliateCredit { get; set; }
        public decimal? AffiliateplusDiscount { get; set; }
        public decimal? BaseAdjustment { get; set; }
        public decimal? BaseAdjustmentNegative { get; set; }
        public decimal? BaseAdjustmentPositive { get; set; }
        public decimal? BaseAffiliateCredit { get; set; }
        public decimal? BaseAffiliateplusDiscount { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseGiftVoucherDiscount { get; set; }
        public decimal? BaseGrandTotal { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal? BaseShippingAmount { get; set; }
        public decimal? BaseShippingHiddenTaxAmnt { get; set; }
        public decimal? BaseShippingInclTax { get; set; }
        public decimal? BaseShippingTaxAmount { get; set; }
        public decimal? BaseSubtotal { get; set; }
        public decimal? BaseSubtotalInclTax { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public decimal? BaseToGlobalRate { get; set; }
        public decimal? BaseToOrderRate { get; set; }
        public decimal? BaseUseGiftCreditAmount { get; set; }
        public int? BillingAddressId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreditmemoStatus { get; set; }
        public decimal? DiscountAmount { get; set; }
        public ushort? EmailSent { get; set; }
        public decimal? GiftVoucherDiscount { get; set; }
        public decimal? GiftcardRefundAmount { get; set; }
        public decimal GiftcreditBaseHiddenTaxAmount { get; set; }
        public decimal GiftcreditHiddenTaxAmount { get; set; }
        public decimal GiftvoucherBaseHiddenTaxAmount { get; set; }
        public decimal GiftvoucherHiddenTaxAmount { get; set; }
        public string GlobalCurrencyCode { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public string IncrementId { get; set; }
        public int? InvoiceId { get; set; }
        public string OrderCurrencyCode { get; set; }
        public int OrderId { get; set; }
        public int? ShippingAddressId { get; set; }
        public decimal? ShippingAmount { get; set; }
        public decimal? ShippingHiddenTaxAmount { get; set; }
        public decimal? ShippingInclTax { get; set; }
        public decimal? ShippingTaxAmount { get; set; }
        public int? State { get; set; }
        public string StoreCurrencyCode { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? StoreToBaseRate { get; set; }
        public decimal? StoreToOrderRate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? SubtotalInclTax { get; set; }
        public decimal? TaxAmount { get; set; }
        public string TransactionId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal? UseGiftCreditAmount { get; set; }

        public virtual ICollection<SalesFlatCreditmemoComment> SalesFlatCreditmemoComment { get; set; }
        public virtual SalesFlatCreditmemoGrid SalesFlatCreditmemoGrid { get; set; }
        public virtual ICollection<SalesFlatCreditmemoItem> SalesFlatCreditmemoItem { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
