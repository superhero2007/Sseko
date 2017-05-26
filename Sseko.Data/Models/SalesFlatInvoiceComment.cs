using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesFlatInvoiceComment
    {
        public int EntityId { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ushort? IsCustomerNotified { get; set; }
        public ushort IsVisibleOnFront { get; set; }
        public int ParentId { get; set; }

        public virtual SalesFlatInvoice Parent { get; set; }
    }
}
