using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DesignChange
    {
        public int DesignChangeId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Design { get; set; }
        public ushort StoreId { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
