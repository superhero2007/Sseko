using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TagProperties
    {
        public int TagId { get; set; }
        public ushort StoreId { get; set; }
        public int BasePopularity { get; set; }

        public virtual CoreStore Store { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
