using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductWebsite
    {
        public int ProductId { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
