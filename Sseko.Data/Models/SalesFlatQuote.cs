using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuote
    {
        public SalesFlatQuote()
        {
            SalesFlatQuoteAddress = new HashSet<SalesFlatQuoteAddress>();
            SalesFlatQuoteItem = new HashSet<SalesFlatQuoteItem>();
            SalesFlatQuotePayment = new HashSet<SalesFlatQuotePayment>();
        }

        public int EntityId { get; set; }
        public string AppliedRuleIds { get; set; }
        public string BaseCurrencyCode { get; set; }
        public decimal? BaseGrandTotal { get; set; }
        public decimal? BaseSubtotal { get; set; }
        public decimal? BaseSubtotalWithDiscount { get; set; }
        public decimal? BaseToGlobalRate { get; set; }
        public decimal? BaseToQuoteRate { get; set; }
        public string CheckoutMethod { get; set; }
        public DateTime? ConvertedAt { get; set; }
        public string CouponCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CustomerDob { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerGender { get; set; }
        public int? CustomerGroupId { get; set; }
        public int? CustomerId { get; set; }
        public ushort? CustomerIsGuest { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerMiddlename { get; set; }
        public string CustomerNote { get; set; }
        public ushort? CustomerNoteNotify { get; set; }
        public string CustomerPrefix { get; set; }
        public string CustomerSuffix { get; set; }
        public int? CustomerTaxClassId { get; set; }
        public string CustomerTaxvat { get; set; }
        public int EbizmartsAbandonedcartCounter { get; set; }
        public int EbizmartsAbandonedcartFlag { get; set; }
        public string EbizmartsAbandonedcartToken { get; set; }
        public string ExtShippingInfo { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal? GiftcardsDiscount { get; set; }
        public string GlobalCurrencyCode { get; set; }
        public decimal? GrandTotal { get; set; }
        public ushort? IsActive { get; set; }
        public int? IsChanged { get; set; }
        public ushort? IsMultiShipping { get; set; }
        public ushort? IsPersistent { get; set; }
        public ushort? IsVirtual { get; set; }
        public int? ItemsCount { get; set; }
        public decimal? ItemsQty { get; set; }
        public int MailchimpAbandonedcartFlag { get; set; }
        public int MailchimpDeleted { get; set; }
        public DateTime MailchimpSyncDelta { get; set; }
        public string MailchimpSyncError { get; set; }
        public string MailchimpToken { get; set; }
        public int? OrigOrderId { get; set; }
        public string PasswordHash { get; set; }
        public string QuoteCurrencyCode { get; set; }
        public string RemoteIp { get; set; }
        public string ReservedOrderId { get; set; }
        public string StoreCurrencyCode { get; set; }
        public ushort StoreId { get; set; }
        public decimal? StoreToBaseRate { get; set; }
        public decimal? StoreToQuoteRate { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? SubtotalWithDiscount { get; set; }
        public short TriggerRecollect { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? UseGiftcards { get; set; }

        public virtual ICollection<SalesFlatQuoteAddress> SalesFlatQuoteAddress { get; set; }
        public virtual ICollection<SalesFlatQuoteItem> SalesFlatQuoteItem { get; set; }
        public virtual ICollection<SalesFlatQuotePayment> SalesFlatQuotePayment { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
