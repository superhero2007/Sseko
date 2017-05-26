using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductEntity
    {
        public CatalogProductEntity()
        {
            AffiliateplusprogramProduct = new HashSet<AffiliateplusprogramProduct>();
            CatalogCategoryProduct = new HashSet<CatalogCategoryProduct>();
            CatalogCategoryProductIndex = new HashSet<CatalogCategoryProductIndex>();
            CatalogCompareItem = new HashSet<CatalogCompareItem>();
            CataloginventoryStockItem = new HashSet<CataloginventoryStockItem>();
            CataloginventoryStockStatus = new HashSet<CataloginventoryStockStatus>();
            CatalogProductBundleOption = new HashSet<CatalogProductBundleOption>();
            CatalogProductBundlePriceIndex = new HashSet<CatalogProductBundlePriceIndex>();
            CatalogProductBundleSelection = new HashSet<CatalogProductBundleSelection>();
            CatalogProductEnabledIndex = new HashSet<CatalogProductEnabledIndex>();
            CatalogProductEntityDatetime = new HashSet<CatalogProductEntityDatetime>();
            CatalogProductEntityDecimal = new HashSet<CatalogProductEntityDecimal>();
            CatalogProductEntityGallery = new HashSet<CatalogProductEntityGallery>();
            CatalogProductEntityGroupPrice = new HashSet<CatalogProductEntityGroupPrice>();
            CatalogProductEntityInt = new HashSet<CatalogProductEntityInt>();
            CatalogProductEntityMediaGallery = new HashSet<CatalogProductEntityMediaGallery>();
            CatalogProductEntityText = new HashSet<CatalogProductEntityText>();
            CatalogProductEntityTierPrice = new HashSet<CatalogProductEntityTierPrice>();
            CatalogProductEntityVarchar = new HashSet<CatalogProductEntityVarchar>();
            CatalogProductIndexEav = new HashSet<CatalogProductIndexEav>();
            CatalogProductIndexEavDecimal = new HashSet<CatalogProductIndexEavDecimal>();
            CatalogProductIndexGroupPrice = new HashSet<CatalogProductIndexGroupPrice>();
            CatalogProductIndexPrice = new HashSet<CatalogProductIndexPrice>();
            CatalogProductIndexTierPrice = new HashSet<CatalogProductIndexTierPrice>();
            CatalogProductLinkLinkedProduct = new HashSet<CatalogProductLink>();
            CatalogProductLinkProduct = new HashSet<CatalogProductLink>();
            CatalogProductOption = new HashSet<CatalogProductOption>();
            CatalogProductRelationChild = new HashSet<CatalogProductRelation>();
            CatalogProductRelationParent = new HashSet<CatalogProductRelation>();
            CatalogProductSuperAttribute = new HashSet<CatalogProductSuperAttribute>();
            CatalogProductSuperLinkParent = new HashSet<CatalogProductSuperLink>();
            CatalogProductSuperLinkProduct = new HashSet<CatalogProductSuperLink>();
            CatalogProductWebsite = new HashSet<CatalogProductWebsite>();
            CatalogruleProduct = new HashSet<CatalogruleProduct>();
            CatalogruleProductPrice = new HashSet<CatalogruleProductPrice>();
            CatalogsearchResult = new HashSet<CatalogsearchResult>();
            CoreUrlRewrite = new HashSet<CoreUrlRewrite>();
            DownloadableLink = new HashSet<DownloadableLink>();
            DownloadableSample = new HashSet<DownloadableSample>();
            ProductAlertPrice = new HashSet<ProductAlertPrice>();
            ProductAlertStock = new HashSet<ProductAlertStock>();
            ReportComparedProductIndex = new HashSet<ReportComparedProductIndex>();
            ReportViewedProductAggregatedDaily = new HashSet<ReportViewedProductAggregatedDaily>();
            ReportViewedProductAggregatedMonthly = new HashSet<ReportViewedProductAggregatedMonthly>();
            ReportViewedProductAggregatedYearly = new HashSet<ReportViewedProductAggregatedYearly>();
            ReportViewedProductIndex = new HashSet<ReportViewedProductIndex>();
            SalesBestsellersAggregatedDaily = new HashSet<SalesBestsellersAggregatedDaily>();
            SalesBestsellersAggregatedMonthly = new HashSet<SalesBestsellersAggregatedMonthly>();
            SalesBestsellersAggregatedYearly = new HashSet<SalesBestsellersAggregatedYearly>();
            SalesFlatQuoteItem = new HashSet<SalesFlatQuoteItem>();
            TagRelation = new HashSet<TagRelation>();
            WeeeTax = new HashSet<WeeeTax>();
            WishlistItem = new HashSet<WishlistItem>();
        }

        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public ushort EntityTypeId { get; set; }
        public short HasOptions { get; set; }
        public ushort RequiredOptions { get; set; }
        public string Sku { get; set; }
        public string TypeId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<AffiliateplusprogramProduct> AffiliateplusprogramProduct { get; set; }
        public virtual ICollection<CatalogCategoryProduct> CatalogCategoryProduct { get; set; }
        public virtual ICollection<CatalogCategoryProductIndex> CatalogCategoryProductIndex { get; set; }
        public virtual ICollection<CatalogCompareItem> CatalogCompareItem { get; set; }
        public virtual ICollection<CataloginventoryStockItem> CataloginventoryStockItem { get; set; }
        public virtual ICollection<CataloginventoryStockStatus> CataloginventoryStockStatus { get; set; }
        public virtual ICollection<CatalogProductBundleOption> CatalogProductBundleOption { get; set; }
        public virtual ICollection<CatalogProductBundlePriceIndex> CatalogProductBundlePriceIndex { get; set; }
        public virtual ICollection<CatalogProductBundleSelection> CatalogProductBundleSelection { get; set; }
        public virtual ICollection<CatalogProductEnabledIndex> CatalogProductEnabledIndex { get; set; }
        public virtual ICollection<CatalogProductEntityDatetime> CatalogProductEntityDatetime { get; set; }
        public virtual ICollection<CatalogProductEntityDecimal> CatalogProductEntityDecimal { get; set; }
        public virtual ICollection<CatalogProductEntityGallery> CatalogProductEntityGallery { get; set; }
        public virtual ICollection<CatalogProductEntityGroupPrice> CatalogProductEntityGroupPrice { get; set; }
        public virtual ICollection<CatalogProductEntityInt> CatalogProductEntityInt { get; set; }
        public virtual ICollection<CatalogProductEntityMediaGallery> CatalogProductEntityMediaGallery { get; set; }
        public virtual ICollection<CatalogProductEntityText> CatalogProductEntityText { get; set; }
        public virtual ICollection<CatalogProductEntityTierPrice> CatalogProductEntityTierPrice { get; set; }
        public virtual ICollection<CatalogProductEntityVarchar> CatalogProductEntityVarchar { get; set; }
        public virtual CatalogProductFlat1 CatalogProductFlat1 { get; set; }
        public virtual CatalogProductFlat2 CatalogProductFlat2 { get; set; }
        public virtual CatalogProductFlat3 CatalogProductFlat3 { get; set; }
        public virtual ICollection<CatalogProductIndexEav> CatalogProductIndexEav { get; set; }
        public virtual ICollection<CatalogProductIndexEavDecimal> CatalogProductIndexEavDecimal { get; set; }
        public virtual ICollection<CatalogProductIndexGroupPrice> CatalogProductIndexGroupPrice { get; set; }
        public virtual ICollection<CatalogProductIndexPrice> CatalogProductIndexPrice { get; set; }
        public virtual ICollection<CatalogProductIndexTierPrice> CatalogProductIndexTierPrice { get; set; }
        public virtual ICollection<CatalogProductLink> CatalogProductLinkLinkedProduct { get; set; }
        public virtual ICollection<CatalogProductLink> CatalogProductLinkProduct { get; set; }
        public virtual ICollection<CatalogProductOption> CatalogProductOption { get; set; }
        public virtual ICollection<CatalogProductRelation> CatalogProductRelationChild { get; set; }
        public virtual ICollection<CatalogProductRelation> CatalogProductRelationParent { get; set; }
        public virtual ICollection<CatalogProductSuperAttribute> CatalogProductSuperAttribute { get; set; }
        public virtual ICollection<CatalogProductSuperLink> CatalogProductSuperLinkParent { get; set; }
        public virtual ICollection<CatalogProductSuperLink> CatalogProductSuperLinkProduct { get; set; }
        public virtual ICollection<CatalogProductWebsite> CatalogProductWebsite { get; set; }
        public virtual ICollection<CatalogruleProduct> CatalogruleProduct { get; set; }
        public virtual ICollection<CatalogruleProductPrice> CatalogruleProductPrice { get; set; }
        public virtual ICollection<CatalogsearchResult> CatalogsearchResult { get; set; }
        public virtual ICollection<CoreUrlRewrite> CoreUrlRewrite { get; set; }
        public virtual ICollection<DownloadableLink> DownloadableLink { get; set; }
        public virtual ICollection<DownloadableSample> DownloadableSample { get; set; }
        public virtual ICollection<ProductAlertPrice> ProductAlertPrice { get; set; }
        public virtual ICollection<ProductAlertStock> ProductAlertStock { get; set; }
        public virtual ICollection<ReportComparedProductIndex> ReportComparedProductIndex { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedDaily> ReportViewedProductAggregatedDaily { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedMonthly> ReportViewedProductAggregatedMonthly { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedYearly> ReportViewedProductAggregatedYearly { get; set; }
        public virtual ICollection<ReportViewedProductIndex> ReportViewedProductIndex { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedDaily> SalesBestsellersAggregatedDaily { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedMonthly> SalesBestsellersAggregatedMonthly { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedYearly> SalesBestsellersAggregatedYearly { get; set; }
        public virtual ICollection<SalesFlatQuoteItem> SalesFlatQuoteItem { get; set; }
        public virtual ICollection<TagRelation> TagRelation { get; set; }
        public virtual ICollection<WeeeTax> WeeeTax { get; set; }
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
        public virtual EavAttributeSet AttributeSet { get; set; }
        public virtual EavEntityType EntityType { get; set; }
    }
}
