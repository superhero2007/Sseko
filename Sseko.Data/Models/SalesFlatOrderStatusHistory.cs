using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatOrderStatusHistory
    {
        public int EntityId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string EntityName { get; set; }
        public int? IsCustomerNotified { get; set; }
        public ushort IsVisibleOnFront { get; set; }
        public int ParentId { get; set; }
        public string Status { get; set; }

        public virtual SalesFlatOrder Parent { get; set; }
    }
}
