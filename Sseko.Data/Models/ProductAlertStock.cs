using System;

namespace Sseko.Data.Models
{
    public partial class ProductAlertStock
    {
        public int AlertStockId { get; set; }
        public DateTime AddDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public ushort SendCount { get; set; }
        public DateTime? SendDate { get; set; }
        public ushort Status { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
