using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaRmaOrder
    {
        public int RmaOrderId { get; set; }
        public int? ReExchangeOrderId { get; set; }
        public int ReRmaId { get; set; }

        public virtual MRmaRma ReRma { get; set; }
    }
}
