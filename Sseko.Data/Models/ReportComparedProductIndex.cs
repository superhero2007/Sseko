using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ReportComparedProductIndex
    {
        public ulong IndexId { get; set; }
        public DateTime AddedAt { get; set; }
        public int? CustomerId { get; set; }
        public int ProductId { get; set; }
        public ushort? StoreId { get; set; }
        public int? VisitorId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
