using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesOrderStatus
    {
        public SalesOrderStatus()
        {
            SalesOrderStatusLabel = new HashSet<SalesOrderStatusLabel>();
            SalesOrderStatusState = new HashSet<SalesOrderStatusState>();
        }

        public string Status { get; set; }
        public string Label { get; set; }

        public virtual ICollection<SalesOrderStatusLabel> SalesOrderStatusLabel { get; set; }
        public virtual ICollection<SalesOrderStatusState> SalesOrderStatusState { get; set; }
    }
}
