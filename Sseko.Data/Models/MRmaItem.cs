using System;

namespace Sseko.Data.Models
{
    public partial class MRmaItem
    {
        public int ItemId { get; set; }
        public int? ConditionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRemoved { get; set; }
        public string Name { get; set; }
        public string OfflineOrderName { get; set; }
        public int? OrderId { get; set; }
        public int? OrderItemId { get; set; }
        public int? ProductId { get; set; }
        public string ProductOptions { get; set; }
        public int? QtyRequested { get; set; }
        public int? QtyReturned { get; set; }
        public int? ReasonId { get; set; }
        public int? ResolutionId { get; set; }
        public int RmaId { get; set; }
        public bool ToStock { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual MRmaCondition Condition { get; set; }
        public virtual SalesFlatOrder Order { get; set; }
        public virtual MRmaReason Reason { get; set; }
        public virtual MRmaResolution Resolution { get; set; }
        public virtual MRmaRma Rma { get; set; }
    }
}
