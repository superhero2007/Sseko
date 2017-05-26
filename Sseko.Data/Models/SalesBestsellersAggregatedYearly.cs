using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesBestsellersAggregatedYearly
    {
        public int Id { get; set; }
        public DateTime? Period { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal QtyOrdered { get; set; }
        public ushort RatingPos { get; set; }
        public ushort? StoreId { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
