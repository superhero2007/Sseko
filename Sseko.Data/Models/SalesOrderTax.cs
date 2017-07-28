using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SalesOrderTax
    {
        public SalesOrderTax()
        {
            SalesOrderTaxItem = new HashSet<SalesOrderTaxItem>();
        }

        public int TaxId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? BaseAmount { get; set; }
        public decimal? BaseRealAmount { get; set; }
        public string Code { get; set; }
        public ushort Hidden { get; set; }
        public int OrderId { get; set; }
        public decimal? Percent { get; set; }
        public int Position { get; set; }
        public int Priority { get; set; }
        public short Process { get; set; }
        public string Title { get; set; }

        public virtual ICollection<SalesOrderTaxItem> SalesOrderTaxItem { get; set; }
    }
}
