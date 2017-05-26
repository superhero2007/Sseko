using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TagSummary
    {
        public int TagId { get; set; }
        public ushort StoreId { get; set; }
        public int BasePopularity { get; set; }
        public int Customers { get; set; }
        public int HistoricalUses { get; set; }
        public int Popularity { get; set; }
        public int Products { get; set; }
        public int Uses { get; set; }

        public virtual CoreStore Store { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
