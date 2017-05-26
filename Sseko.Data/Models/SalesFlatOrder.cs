using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrder
    {
        public SalesFlatOrder()
        {
            DownloadableLinkPurchased = new HashSet<DownloadableLinkPurchased>();
            MRmaItem = new HashSet<MRmaItem>();
            SalesBillingAgreementOrder = new HashSet<SalesBillingAgreementOrder>();
            SalesFlatCreditmemo = new HashSet<SalesFlatCreditmemo>();
            SalesFlatInvoice = new HashSet<SalesFlatInvoice>();
            SalesFlatOrderAddress = new HashSet<SalesFlatOrderAddress>();
            SalesFlatOrderItem = new HashSet<SalesFlatOrderItem>();
            SalesFlatOrderPayment = new HashSet<SalesFlatOrderPayment>();
            SalesFlatOrderStatusHistory = new HashSet<SalesFlatOrderStatusHistory>();
            SalesFlatShipment = new HashSet<SalesFlatShipment>();
            SalesPaymentTransaction = new HashSet<SalesPaymentTransaction>();
            SalesRecurringProfileOrder = new HashSet<SalesRecurringProfileOrder>();
        }

        public int EntityId { get; set; }
        public decimal? AdjustmentNegative { get; set; }
        public decimal? AdjustmentPositive { get; set; }
        public decimal? AffiliateCredit { get; set; }
        public string AffiliateplusCoupon { get; set; }
        public decimal? AffiliateplusDiscount { get; set; }
        public string AppliedRuleIds { get; set; }
        public decimal? BaseAdjustmentNegative { get; set; }
        public decimal? BaseAdjustmentPositive { get; set; }
        public decimal? BaseAffiliateCredit { get; set; }
        public decimal? BaseAffiliateplusDiscount { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseDiscountCanceled { get; set; }
        public decimal? BaseDiscountInvoiced { get; set; }
        public decimal? BaseDiscountRefunded { get; set; }
        public decimal BaseGiftVoucherDiscount { get; set; }
        public decimal? BaseGiftcreditDiscountForShipping { get; set; }
        public decimal? BaseGiftvoucherDiscountForShipping { get; set; }
        public decimal? BaseGrandTotal { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal? BaseHiddenTaxInvoiced { get; set; }
        public decimal? BaseHiddenTaxRefunded { get; set; }
        public decimal? BaseShippingAmount { get; set; }
        public decimal? BaseShippingCanceled { get; set; }
        public decimal? BaseShippingDiscountAmount { get; set; }
        public decimal? BaseShippingHiddenTaxAmnt { get; set; }
        public decimal? BaseShippingInclTax { get; set; }
        public decimal? BaseShippingInvoiced { get; set; }
        public decimal? BaseShippingRefunded { get; set; }
        public decimal? BaseShippingTaxAmount { get; set; }
        public decimal? BaseShippingTaxRefunded { get; set; }
        public decimal? BaseSubtotal { get; set; }
        public decimal? BaseSubtotalCanceled { get; set; }
        public decimal? BaseSubtotalInclTax { get; set; }
        public decimal? BaseSubtotalInvoiced { get; set; }
        public decimal? BaseSubtotalRefunded { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public decimal? BaseTaxCanceled { get; set; }
        public decimal? BaseTaxInvoiced { get; set; }
        public decimal? BaseTaxRefunded { get; set; }
        public decimal? BaseToGlobalRate { get; set; }
        public decimal? BaseToOrderRate { get; set; }
        public decimal? BaseTotalCanceled { get; set; }
        public decimal? BaseTotalDue { get; set; }
        public decimal? BaseTotalInvoiced { get; set; }
        public decimal? BaseTotalInvoicedCost { get; set; }
        public decimal? BaseTotalOfflineRefunded { get; set; }
        public decimal? BaseTotalOnlineRefunded { get; set; }
        public decimal? BaseTotalPaid { get; set; }
        public decimal? BaseTotalQtyOrdered { get; set; }
        public decimal? BaseTotalRefunded { get; set; }
        public decimal BaseUseGiftCreditAmount { get; set; }
        public int? BillingAddressId { get; set; }
        public ushort? CanShipPartially { get; set; }
        public ushort? CanShipPartiallyItem { get; set; }
        public string CouponCode { get; set; }
        public string CouponRuleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CustomerDob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstname { get; set; }
        public int? CustomerGender { get; set; }
        public short? CustomerGroupId { get; set; }
        public int? CustomerId { get; set; }
        public ushort? CustomerIsGuest { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerMiddlename { get; set; }
        public string CustomerNote { get; set; }
        public ushort? CustomerNoteNotify { get; set; }
        public string CustomerPrefix { get; set; }
        public string CustomerSuffix { get; set; }
        public string CustomerTaxvat { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountCanceled { get; set; }
        public string DiscountDescription { get; set; }
        public decimal? DiscountInvoiced { get; set; }
        public decimal? DiscountRefunded { get; set; }
        public int? EbizmartsAbandonedcartFlag { get; set; }
        public string EbizmartsMagemonkeyCampaignId { get; set; }
        public int? EditIncrement { get; set; }
        public ushort? EmailSent { get; set; }
        public string ExtCustomerId { get; set; }
        public string ExtOrderId { get; set; }
        public ushort? ForcedShipmentWithInvoice { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal GiftVoucherDiscount { get; set; }
        public decimal GiftcreditBaseHiddenTaxAmount { get; set; }
        public decimal GiftcreditBaseShippingHiddenTaxAmount { get; set; }
        public decimal? GiftcreditDiscountForShipping { get; set; }
        public decimal GiftcreditHiddenTaxAmount { get; set; }
        public decimal GiftcreditShippingHiddenTaxAmount { get; set; }
        public decimal GiftvoucherBaseHiddenTaxAmount { get; set; }
        public decimal GiftvoucherBaseShippingHiddenTaxAmount { get; set; }
        public decimal? GiftvoucherDiscountForShipping { get; set; }
        public decimal GiftvoucherHiddenTaxAmount { get; set; }
        public decimal GiftvoucherShippingHiddenTaxAmount { get; set; }
        public string GlobalCurrencyCode { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public decimal? HiddenTaxInvoiced { get; set; }
        public decimal? HiddenTaxRefunded { get; set; }
        public string HoldBeforeState { get; set; }
        public string HoldBeforeStatus { get; set; }
        public string IncrementId { get; set; }
        public ushort? IsVirtual { get; set; }
        public int MailchimpAbandonedcartFlag { get; set; }
        public string MailchimpCampaignId { get; set; }
        public DateTime MailchimpSyncDelta { get; set; }
        public string MailchimpSyncError { get; set; }
        public decimal? OnestepcheckoutGiftwrapAmount { get; set; }
        public string OnestepcheckoutOrderComment { get; set; }
        public string OrderCurrencyCode { get; set; }
        public string OriginalIncrementId { get; set; }
        public int? PaymentAuthExpiration { get; set; }
        public decimal? PaymentAuthorizationAmount { get; set; }
        public int? PaypalIpnCustomerNotified { get; set; }
        public string ProtectCode { get; set; }
        public int? QuoteAddressId { get; set; }
        public int? QuoteId { get; set; }
        public string RelationChildId { get; set; }
        public string RelationChildRealId { get; set; }
        public string RelationParentId { get; set; }
        public string RelationParentRealId { get; set; }
        public string RemoteIp { get; set; }
        public int? ShippingAddressId { get; set; }
        public decimal? ShippingAmount { get; set; }
        public decimal? ShippingCanceled { get; set; }
        public string ShippingDescription { get; set; }
        public decimal? ShippingDiscountAmount { get; set; }
        public decimal? ShippingHiddenTaxAmount { get; set; }
        public decimal? ShippingInclTax { get; set; }
        public decimal? ShippingInvoiced { get; set; }
        public string ShippingMethod { get; set; }
        public decimal? ShippingRefunded { get; set; }
        public decimal? ShippingTaxAmount { get; set; }
        public decimal? ShippingTaxRefunded { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string StoreCurrencyCode { get; set; }
        public ushort? StoreId { get; set; }
        public string StoreName { get; set; }
        public decimal? StoreToBaseRate { get; set; }
        public decimal? StoreToOrderRate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? SubtotalCanceled { get; set; }
        public decimal? SubtotalInclTax { get; set; }
        public decimal? SubtotalInvoiced { get; set; }
        public decimal? SubtotalRefunded { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxCanceled { get; set; }
        public decimal? TaxInvoiced { get; set; }
        public decimal? TaxRefunded { get; set; }
        public decimal? TotalCanceled { get; set; }
        public decimal? TotalDue { get; set; }
        public decimal? TotalInvoiced { get; set; }
        public ushort TotalItemCount { get; set; }
        public decimal? TotalOfflineRefunded { get; set; }
        public decimal? TotalOnlineRefunded { get; set; }
        public decimal? TotalPaid { get; set; }
        public decimal? TotalQtyOrdered { get; set; }
        public decimal? TotalRefunded { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal UseGiftCreditAmount { get; set; }
        public decimal? Weight { get; set; }
        public string XForwardedFor { get; set; }

        public virtual ICollection<DownloadableLinkPurchased> DownloadableLinkPurchased { get; set; }
        public virtual ICollection<MRmaItem> MRmaItem { get; set; }
        public virtual ICollection<SalesBillingAgreementOrder> SalesBillingAgreementOrder { get; set; }
        public virtual ICollection<SalesFlatCreditmemo> SalesFlatCreditmemo { get; set; }
        public virtual ICollection<SalesFlatInvoice> SalesFlatInvoice { get; set; }
        public virtual ICollection<SalesFlatOrderAddress> SalesFlatOrderAddress { get; set; }
        public virtual SalesFlatOrderGrid SalesFlatOrderGrid { get; set; }
        public virtual ICollection<SalesFlatOrderItem> SalesFlatOrderItem { get; set; }
        public virtual ICollection<SalesFlatOrderPayment> SalesFlatOrderPayment { get; set; }
        public virtual ICollection<SalesFlatOrderStatusHistory> SalesFlatOrderStatusHistory { get; set; }
        public virtual ICollection<SalesFlatShipment> SalesFlatShipment { get; set; }
        public virtual ICollection<SalesPaymentTransaction> SalesPaymentTransaction { get; set; }
        public virtual ICollection<SalesRecurringProfileOrder> SalesRecurringProfileOrder { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
