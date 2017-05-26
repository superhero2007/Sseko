using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogCategoryProduct
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int Position { get; set; }

        public virtual CatalogCategoryEntity Category { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
