using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrderItem
    {
        public SalesFlatOrderItem()
        {
            DownloadableLinkPurchasedItem = new HashSet<DownloadableLinkPurchasedItem>();
            SalesOrderTaxItem = new HashSet<SalesOrderTaxItem>();
        }

        public int ItemId { get; set; }
        public string AdditionalData { get; set; }
        public decimal? AffiliateplusAmount { get; set; }
        public decimal? AffiliateplusCommission { get; set; }
        public string AffiliateplusCommissionItem { get; set; }
        public decimal? AffiliateplusCredit { get; set; }
        public decimal? AmountRefunded { get; set; }
        public string AppliedRuleIds { get; set; }
        public decimal? BaseAffiliateplusAmount { get; set; }
        public decimal? BaseAffiliateplusCredit { get; set; }
        public decimal? BaseAmountRefunded { get; set; }
        public decimal? BaseCost { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseDiscountInvoiced { get; set; }
        public decimal? BaseDiscountRefunded { get; set; }
        public decimal? BaseGiftVoucherDiscount { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal? BaseHiddenTaxInvoiced { get; set; }
        public decimal? BaseHiddenTaxRefunded { get; set; }
        public decimal? BaseOriginalPrice { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? BasePriceInclTax { get; set; }
        public decimal BaseRowInvoiced { get; set; }
        public decimal BaseRowTotal { get; set; }
        public decimal? BaseRowTotalInclTax { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public decimal? BaseTaxBeforeDiscount { get; set; }
        public decimal? BaseTaxInvoiced { get; set; }
        public decimal? BaseTaxRefunded { get; set; }
        public decimal? BaseUseGiftCreditAmount { get; set; }
        public decimal? BaseWeeeTaxAppliedAmount { get; set; }
        public decimal? BaseWeeeTaxAppliedRowAmnt { get; set; }
        public decimal? BaseWeeeTaxDisposition { get; set; }
        public decimal? BaseWeeeTaxRowDisposition { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountInvoiced { get; set; }
        public decimal? DiscountPercent { get; set; }
        public decimal? DiscountRefunded { get; set; }
        public string ExtOrderItemId { get; set; }
        public ushort FreeShipping { get; set; }
        public int? GiftMessageAvailable { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal? GiftVoucherDiscount { get; set; }
        public decimal GiftcreditBaseHiddenTaxAmount { get; set; }
        public decimal GiftcreditHiddenTaxAmount { get; set; }
        public decimal GiftvoucherBaseHiddenTaxAmount { get; set; }
        public decimal GiftvoucherHiddenTaxAmount { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public decimal? HiddenTaxCanceled { get; set; }
        public decimal? HiddenTaxInvoiced { get; set; }
        public decimal? HiddenTaxRefunded { get; set; }
        public int IsNominal { get; set; }
        public ushort? IsQtyDecimal { get; set; }
        public ushort? IsVirtual { get; set; }
        public ushort? LockedDoInvoice { get; set; }
        public ushort? LockedDoShip { get; set; }
        public string Name { get; set; }
        public ushort NoDiscount { get; set; }
        public int OrderId { get; set; }
        public decimal? OriginalPrice { get; set; }
        public int? ParentItemId { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceInclTax { get; set; }
        public int? ProductId { get; set; }
        public string ProductOptions { get; set; }
        public string ProductType { get; set; }
        public decimal? QtyBackordered { get; set; }
        public decimal? QtyCanceled { get; set; }
        public decimal? QtyInvoiced { get; set; }
        public decimal? QtyOrdered { get; set; }
        public decimal? QtyRefunded { get; set; }
        public decimal? QtyShipped { get; set; }
        public int? QuoteItemId { get; set; }
        public decimal RowInvoiced { get; set; }
        public decimal RowTotal { get; set; }
        public decimal? RowTotalInclTax { get; set; }
        public decimal? RowWeight { get; set; }
        public string Sku { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxBeforeDiscount { get; set; }
        public decimal? TaxCanceled { get; set; }
        public decimal? TaxInvoiced { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? TaxRefunded { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal? UseGiftCreditAmount { get; set; }
        public string WeeeTaxApplied { get; set; }
        public decimal? WeeeTaxAppliedAmount { get; set; }
        public decimal? WeeeTaxAppliedRowAmount { get; set; }
        public decimal? WeeeTaxDisposition { get; set; }
        public decimal? WeeeTaxRowDisposition { get; set; }
        public decimal? Weight { get; set; }

        public virtual ICollection<DownloadableLinkPurchasedItem> DownloadableLinkPurchasedItem { get; set; }
        public virtual ICollection<SalesOrderTaxItem> SalesOrderTaxItem { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
