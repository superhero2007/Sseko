using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuoteAddressItem
    {
        public int AddressItemId { get; set; }
        public string AdditionalData { get; set; }
        public string AppliedRuleIds { get; set; }
        public decimal? BaseCost { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? BasePriceInclTax { get; set; }
        public decimal BaseRowTotal { get; set; }
        public decimal? BaseRowTotalInclTax { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercent { get; set; }
        public int? FreeShipping { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public string Image { get; set; }
        public int? IsQtyDecimal { get; set; }
        public string Name { get; set; }
        public int? NoDiscount { get; set; }
        public int? ParentItemId { get; set; }
        public int? ParentProductId { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceInclTax { get; set; }
        public int? ProductId { get; set; }
        public decimal Qty { get; set; }
        public int QuoteAddressId { get; set; }
        public int QuoteItemId { get; set; }
        public decimal RowTotal { get; set; }
        public decimal? RowTotalInclTax { get; set; }
        public decimal? RowTotalWithDiscount { get; set; }
        public decimal? RowWeight { get; set; }
        public string Sku { get; set; }
        public int? SuperProductId { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxPercent { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal? Weight { get; set; }

        public virtual SalesFlatQuoteAddressItem ParentItem { get; set; }
        public virtual ICollection<SalesFlatQuoteAddressItem> InverseParentItem { get; set; }
        public virtual SalesFlatQuoteAddress QuoteAddress { get; set; }
        public virtual SalesFlatQuoteItem QuoteItem { get; set; }
    }
}
