using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreUrlRewrite
    {
        public int UrlRewriteId { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public string IdPath { get; set; }
        public ushort? IsSystem { get; set; }
        public string Options { get; set; }
        public int? ProductId { get; set; }
        public string RequestPath { get; set; }
        public ushort StoreId { get; set; }
        public string TargetPath { get; set; }

        public virtual CatalogCategoryEntity Category { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
