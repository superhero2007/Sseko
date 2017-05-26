using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ProductAlertPrice
    {
        public int AlertPriceId { get; set; }
        public DateTime AddDate { get; set; }
        public int CustomerId { get; set; }
        public DateTime? LastSendDate { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public ushort SendCount { get; set; }
        public ushort Status { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
