using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogCategoryEntity
    {
        public CatalogCategoryEntity()
        {
            AffiliateplusprogramCategory = new HashSet<AffiliateplusprogramCategory>();
            CatalogCategoryEntityDatetime = new HashSet<CatalogCategoryEntityDatetime>();
            CatalogCategoryEntityDecimal = new HashSet<CatalogCategoryEntityDecimal>();
            CatalogCategoryEntityInt = new HashSet<CatalogCategoryEntityInt>();
            CatalogCategoryEntityText = new HashSet<CatalogCategoryEntityText>();
            CatalogCategoryEntityVarchar = new HashSet<CatalogCategoryEntityVarchar>();
            CatalogCategoryProduct = new HashSet<CatalogCategoryProduct>();
            CatalogCategoryProductIndex = new HashSet<CatalogCategoryProductIndex>();
            CoreUrlRewrite = new HashSet<CoreUrlRewrite>();
        }

        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public int ChildrenCount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ushort EntityTypeId { get; set; }
        public int Level { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public int Position { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<AffiliateplusprogramCategory> AffiliateplusprogramCategory { get; set; }
        public virtual ICollection<CatalogCategoryEntityDatetime> CatalogCategoryEntityDatetime { get; set; }
        public virtual ICollection<CatalogCategoryEntityDecimal> CatalogCategoryEntityDecimal { get; set; }
        public virtual ICollection<CatalogCategoryEntityInt> CatalogCategoryEntityInt { get; set; }
        public virtual ICollection<CatalogCategoryEntityText> CatalogCategoryEntityText { get; set; }
        public virtual ICollection<CatalogCategoryEntityVarchar> CatalogCategoryEntityVarchar { get; set; }
        public virtual CatalogCategoryFlatStore1 CatalogCategoryFlatStore1 { get; set; }
        public virtual CatalogCategoryFlatStore2 CatalogCategoryFlatStore2 { get; set; }
        public virtual CatalogCategoryFlatStore3 CatalogCategoryFlatStore3 { get; set; }
        public virtual ICollection<CatalogCategoryProduct> CatalogCategoryProduct { get; set; }
        public virtual ICollection<CatalogCategoryProductIndex> CatalogCategoryProductIndex { get; set; }
        public virtual ICollection<CoreUrlRewrite> CoreUrlRewrite { get; set; }
    }
}
