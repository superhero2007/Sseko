using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuoteAddress
    {
        public SalesFlatQuoteAddress()
        {
            SalesFlatQuoteAddressItem = new HashSet<SalesFlatQuoteAddressItem>();
            SalesFlatQuoteShippingRate = new HashSet<SalesFlatQuoteShippingRate>();
        }

        public int AddressId { get; set; }
        public string AddressType { get; set; }
        public string AppliedTaxes { get; set; }
        public decimal BaseDiscountAmount { get; set; }
        public decimal BaseGrandTotal { get; set; }
        public decimal? BaseHiddenTaxAmount { get; set; }
        public decimal BaseShippingAmount { get; set; }
        public decimal? BaseShippingDiscountAmount { get; set; }
        public decimal? BaseShippingHiddenTaxAmnt { get; set; }
        public decimal? BaseShippingInclTax { get; set; }
        public decimal? BaseShippingTaxAmount { get; set; }
        public decimal BaseSubtotal { get; set; }
        public decimal? BaseSubtotalTotalInclTax { get; set; }
        public decimal BaseSubtotalWithDiscount { get; set; }
        public decimal BaseTaxAmount { get; set; }
        public string City { get; set; }
        public ushort CollectShippingRates { get; set; }
        public string Company { get; set; }
        public string CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CustomerAddressId { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerNotes { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountDescription { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Firstname { get; set; }
        public ushort FreeShipping { get; set; }
        public int? GiftMessageId { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal? HiddenTaxAmount { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Postcode { get; set; }
        public string Prefix { get; set; }
        public int QuoteId { get; set; }
        public string Region { get; set; }
        public int? RegionId { get; set; }
        public ushort SameAsBilling { get; set; }
        public short? SaveInAddressBook { get; set; }
        public decimal ShippingAmount { get; set; }
        public string ShippingDescription { get; set; }
        public decimal? ShippingDiscountAmount { get; set; }
        public decimal? ShippingHiddenTaxAmount { get; set; }
        public decimal? ShippingInclTax { get; set; }
        public string ShippingMethod { get; set; }
        public decimal? ShippingTaxAmount { get; set; }
        public string Street { get; set; }
        public decimal Subtotal { get; set; }
        public decimal? SubtotalInclTax { get; set; }
        public decimal SubtotalWithDiscount { get; set; }
        public string Suffix { get; set; }
        public decimal TaxAmount { get; set; }
        public string Telephone { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string VatId { get; set; }
        public short? VatIsValid { get; set; }
        public string VatRequestDate { get; set; }
        public string VatRequestId { get; set; }
        public short? VatRequestSuccess { get; set; }
        public decimal Weight { get; set; }

        public virtual ICollection<SalesFlatQuoteAddressItem> SalesFlatQuoteAddressItem { get; set; }
        public virtual ICollection<SalesFlatQuoteShippingRate> SalesFlatQuoteShippingRate { get; set; }
        public virtual SalesFlatQuote Quote { get; set; }
    }
}
