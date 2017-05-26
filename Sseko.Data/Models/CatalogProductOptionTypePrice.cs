using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductOptionTypePrice
    {
        public int OptionTypePriceId { get; set; }
        public int OptionTypeId { get; set; }
        public decimal Price { get; set; }
        public string PriceType { get; set; }
        public ushort StoreId { get; set; }

        public virtual CatalogProductOptionTypeValue OptionType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
