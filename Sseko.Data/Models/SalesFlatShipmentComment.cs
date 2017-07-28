using System;

namespace Sseko.Data.Models
{
    public partial class SalesFlatShipmentComment
    {
        public int EntityId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? IsCustomerNotified { get; set; }
        public ushort IsVisibleOnFront { get; set; }
        public int ParentId { get; set; }

        public virtual SalesFlatShipment Parent { get; set; }
    }
}
