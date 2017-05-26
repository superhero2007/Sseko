using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuoteItem
    {
        public SalesFlatQuoteItem()
        {
            SalesFlatQuoteAddressItem = new HashSet<SalesFlatQuoteAddressItem>();
            SalesFlatQuoteItemOption = new HashSet<SalesFlatQuoteItemOption>();
        }

        public int ItemId { get; set; }
        public string AdditionalData { get; set; }
        public string AppliedRuleIds { get; set; }
        public decimal? BaseCost { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal BasePrice { get; set; }
        public decimal? BasePriceInclTax { get; set; }
        public decimal BaseRowTotal { get; set; }
        public decimal? BaseRowTotalInclTax { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public decimal? BaseTaxBeforeDiscount { get; set; }
        public decimal? BaseWeeeTaxAppliedAmount { get; set; }
        public decimal? BaseWeeeTaxAppliedRowAmnt { get; set; }
        public decimal? BaseWeeeTaxDisposition { get; set; }
        public decimal? BaseWeeeTaxRowDisposition { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? CustomPrice { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public ushort FreeShipping { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public ushort? IsQtyDecimal { get; set; }
        public ushort? IsVirtual { get; set; }
        public string Name { get; set; }
        public ushort? NoDiscount { get; set; }
        public decimal? OriginalCustomPrice { get; set; }
        public int? ParentItemId { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceInclTax { get; set; }
        public int? ProductId { get; set; }
        public string ProductType { get; set; }
        public decimal Qty { get; set; }
        public int QuoteId { get; set; }
        public string RedirectUrl { get; set; }
        public decimal RowTotal { get; set; }
        public decimal? RowTotalInclTax { get; set; }
        public decimal? RowTotalWithDiscount { get; set; }
        public decimal? RowWeight { get; set; }
        public string Sku { get; set; }
        public ushort? StoreId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxBeforeDiscount { get; set; }
        public decimal? TaxPercent { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string WeeeTaxApplied { get; set; }
        public decimal? WeeeTaxAppliedAmount { get; set; }
        public decimal? WeeeTaxAppliedRowAmount { get; set; }
        public decimal? WeeeTaxDisposition { get; set; }
        public decimal? WeeeTaxRowDisposition { get; set; }
        public decimal? Weight { get; set; }

        public virtual ICollection<SalesFlatQuoteAddressItem> SalesFlatQuoteAddressItem { get; set; }
        public virtual ICollection<SalesFlatQuoteItemOption> SalesFlatQuoteItemOption { get; set; }
        public virtual SalesFlatQuoteItem ParentItem { get; set; }
        public virtual ICollection<SalesFlatQuoteItem> InverseParentItem { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual SalesFlatQuote Quote { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
