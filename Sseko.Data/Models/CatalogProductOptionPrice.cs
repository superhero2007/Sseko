using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductOptionPrice
    {
        public int OptionPriceId { get; set; }
        public int OptionId { get; set; }
        public decimal Price { get; set; }
        public string PriceType { get; set; }
        public ushort StoreId { get; set; }

        public virtual CatalogProductOption Option { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
