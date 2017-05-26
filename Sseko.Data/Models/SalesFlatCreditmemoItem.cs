using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatCreditmemoItem
    {
        public int EntityId { get; set; }
        public string AdditionalData { get; set; }
        public short? AffiliateplusCommissionFlag { get; set; }
        public decimal? BaseCost { get; set; }
        public decimal? BaseDiscountAmount { get; set; }
        public decimal? BaseGiftVoucherDiscount { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? BasePriceInclTax { get; set; }
        public decimal? BaseRowTotal { get; set; }
        public decimal? BaseRowTotalInclTax { get; set; }
        public decimal? BaseTaxAmount { get; set; }
        public decimal? BaseUseGiftCreditAmount { get; set; }
        public decimal? BaseWeeeTaxAppliedAmount { get; set; }
        public decimal? BaseWeeeTaxAppliedRowAmnt { get; set; }
        public decimal? BaseWeeeTaxDisposition { get; set; }
        public decimal? BaseWeeeTaxRowDisposition { get; set; }
        public string Description { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? GiftVoucherDiscount { get; set; }
        public decimal? GiftcardRefundAmount { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public string Name { get; set; }
        public int? OrderItemId { get; set; }
        public int ParentId { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceInclTax { get; set; }
        public int? ProductId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? RowTotal { get; set; }
        public decimal? RowTotalInclTax { get; set; }
        public string Sku { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? UseGiftCreditAmount { get; set; }
        public string WeeeTaxApplied { get; set; }
        public decimal? WeeeTaxAppliedAmount { get; set; }
        public decimal? WeeeTaxAppliedRowAmount { get; set; }
        public decimal? WeeeTaxDisposition { get; set; }
        public decimal? WeeeTaxRowDisposition { get; set; }

        public virtual SalesFlatCreditmemo Parent { get; set; }
    }
}
