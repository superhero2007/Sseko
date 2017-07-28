using System;

namespace Sseko.Data.Models
{
    public partial class CatalogCategoryFlatStore1
    {
        public int EntityId { get; set; }
        public string AllChildren { get; set; }
        public string AvailableSortBy { get; set; }
        public string Children { get; set; }
        public int ChildrenCount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomApplyToProducts { get; set; }
        public string CustomDesign { get; set; }
        public DateTime? CustomDesignFrom { get; set; }
        public DateTime? CustomDesignTo { get; set; }
        public string CustomLayoutUpdate { get; set; }
        public int? CustomUseParentSettings { get; set; }
        public string DefaultSortBy { get; set; }
        public string Description { get; set; }
        public string DisplayMode { get; set; }
        public decimal? FilterPriceRange { get; set; }
        public string Image { get; set; }
        public int? IncludeInMenu { get; set; }
        public int? IsActive { get; set; }
        public int? IsAnchor { get; set; }
        public int? LandingPage { get; set; }
        public int Level { get; set; }
        public string MarketingTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string Name { get; set; }
        public string PageLayout { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public string PathInStore { get; set; }
        public int Position { get; set; }
        public ushort StoreId { get; set; }
        public string Thumbnail { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UrlKey { get; set; }
        public string UrlPath { get; set; }

        public virtual CatalogCategoryEntity Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
