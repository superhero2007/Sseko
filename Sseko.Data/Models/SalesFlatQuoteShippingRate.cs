using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatQuoteShippingRate
    {
        public int RateId { get; set; }
        public int AddressId { get; set; }
        public string Carrier { get; set; }
        public string CarrierTitle { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ErrorMessage { get; set; }
        public string Method { get; set; }
        public string MethodDescription { get; set; }
        public string MethodTitle { get; set; }
        public decimal Price { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual SalesFlatQuoteAddress Address { get; set; }
    }
}
