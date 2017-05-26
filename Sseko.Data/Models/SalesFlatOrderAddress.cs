using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrderAddress
    {
        public int EntityId { get; set; }
        public string AddressType { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string CountryId { get; set; }
        public int? CustomerAddressId { get; set; }
        public int? CustomerId { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public int? ParentId { get; set; }
        public string Postcode { get; set; }
        public string Prefix { get; set; }
        public int? QuoteAddressId { get; set; }
        public string Region { get; set; }
        public int? RegionId { get; set; }
        public string Street { get; set; }
        public string Suffix { get; set; }
        public string Telephone { get; set; }
        public string VatId { get; set; }
        public short? VatIsValid { get; set; }
        public string VatRequestDate { get; set; }
        public string VatRequestId { get; set; }
        public short? VatRequestSuccess { get; set; }

        public virtual SalesFlatOrder Parent { get; set; }
    }
}
