using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogCategoryProductIndex
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public ushort StoreId { get; set; }
        public ushort IsParent { get; set; }
        public int? Position { get; set; }
        public ushort Visibility { get; set; }

        public virtual CatalogCategoryEntity Category { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
