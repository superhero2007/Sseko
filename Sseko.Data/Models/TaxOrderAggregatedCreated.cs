using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TaxOrderAggregatedCreated
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string OrderStatus { get; set; }
        public int OrdersCount { get; set; }
        public float? Percent { get; set; }
        public DateTime? Period { get; set; }
        public ushort? StoreId { get; set; }
        public float? TaxBaseAmountSum { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
