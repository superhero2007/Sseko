using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaOfflineItem
    {
        public int OfflineItemId { get; set; }
        public int? ConditionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public int OfflineOrderId { get; set; }
        public int? QtyRequested { get; set; }
        public int? QtyReturned { get; set; }
        public int? ReasonId { get; set; }
        public int? ResolutionId { get; set; }
        public int RmaId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual MRmaCondition Condition { get; set; }
        public virtual MRmaOfflineOrder OfflineOrder { get; set; }
        public virtual MRmaReason Reason { get; set; }
        public virtual MRmaResolution Resolution { get; set; }
        public virtual MRmaRma Rma { get; set; }
    }
}
