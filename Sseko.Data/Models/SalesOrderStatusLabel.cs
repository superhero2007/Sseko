using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesOrderStatusLabel
    {
        public string Status { get; set; }
        public ushort StoreId { get; set; }
        public string Label { get; set; }

        public virtual SalesOrderStatus StatusNavigation { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
