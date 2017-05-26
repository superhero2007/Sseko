using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaRmaCreditmemo
    {
        public int RmaCreditmemoId { get; set; }
        public int? RcCreditMemoId { get; set; }
        public int RcRmaId { get; set; }

        public virtual MRmaRma RcRma { get; set; }
    }
}
