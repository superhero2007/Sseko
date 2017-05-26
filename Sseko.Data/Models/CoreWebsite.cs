using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreWebsite
    {
        public CoreWebsite()
        {
            CataloginventoryStockStatus = new HashSet<CataloginventoryStockStatus>();
            CatalogProductBundlePriceIndex = new HashSet<CatalogProductBundlePriceIndex>();
            CatalogProductBundleSelectionPrice = new HashSet<CatalogProductBundleSelectionPrice>();
            CatalogProductEntityGroupPrice = new HashSet<CatalogProductEntityGroupPrice>();
            CatalogProductEntityTierPrice = new HashSet<CatalogProductEntityTierPrice>();
            CatalogProductIndexGroupPrice = new HashSet<CatalogProductIndexGroupPrice>();
            CatalogProductIndexPrice = new HashSet<CatalogProductIndexPrice>();
            CatalogProductIndexTierPrice = new HashSet<CatalogProductIndexTierPrice>();
            CatalogProductSuperAttributePricing = new HashSet<CatalogProductSuperAttributePricing>();
            CatalogProductWebsite = new HashSet<CatalogProductWebsite>();
            CatalogruleGroupWebsite = new HashSet<CatalogruleGroupWebsite>();
            CatalogruleProduct = new HashSet<CatalogruleProduct>();
            CatalogruleProductPrice = new HashSet<CatalogruleProductPrice>();
            CatalogruleWebsite = new HashSet<CatalogruleWebsite>();
            CoreStore = new HashSet<CoreStore>();
            CoreStoreGroup = new HashSet<CoreStoreGroup>();
            CustomerEavAttributeWebsite = new HashSet<CustomerEavAttributeWebsite>();
            CustomerEntity = new HashSet<CustomerEntity>();
            DownloadableLinkPrice = new HashSet<DownloadableLinkPrice>();
            PaypalCert = new HashSet<PaypalCert>();
            PersistentSession = new HashSet<PersistentSession>();
            ProductAlertPrice = new HashSet<ProductAlertPrice>();
            ProductAlertStock = new HashSet<ProductAlertStock>();
            SalesruleProductAttribute = new HashSet<SalesruleProductAttribute>();
            SalesruleWebsite = new HashSet<SalesruleWebsite>();
            WeeeTax = new HashSet<WeeeTax>();
        }

        public ushort WebsiteId { get; set; }
        public string Code { get; set; }
        public ushort DefaultGroupId { get; set; }
        public ushort? IsDefault { get; set; }
        public string Name { get; set; }
        public ushort SortOrder { get; set; }

        public virtual ICollection<CataloginventoryStockStatus> CataloginventoryStockStatus { get; set; }
        public virtual ICollection<CatalogProductBundlePriceIndex> CatalogProductBundlePriceIndex { get; set; }
        public virtual ICollection<CatalogProductBundleSelectionPrice> CatalogProductBundleSelectionPrice { get; set; }
        public virtual ICollection<CatalogProductEntityGroupPrice> CatalogProductEntityGroupPrice { get; set; }
        public virtual ICollection<CatalogProductEntityTierPrice> CatalogProductEntityTierPrice { get; set; }
        public virtual ICollection<CatalogProductIndexGroupPrice> CatalogProductIndexGroupPrice { get; set; }
        public virtual ICollection<CatalogProductIndexPrice> CatalogProductIndexPrice { get; set; }
        public virtual ICollection<CatalogProductIndexTierPrice> CatalogProductIndexTierPrice { get; set; }
        public virtual CatalogProductIndexWebsite CatalogProductIndexWebsite { get; set; }
        public virtual ICollection<CatalogProductSuperAttributePricing> CatalogProductSuperAttributePricing { get; set; }
        public virtual ICollection<CatalogProductWebsite> CatalogProductWebsite { get; set; }
        public virtual ICollection<CatalogruleGroupWebsite> CatalogruleGroupWebsite { get; set; }
        public virtual ICollection<CatalogruleProduct> CatalogruleProduct { get; set; }
        public virtual ICollection<CatalogruleProductPrice> CatalogruleProductPrice { get; set; }
        public virtual ICollection<CatalogruleWebsite> CatalogruleWebsite { get; set; }
        public virtual ICollection<CoreStore> CoreStore { get; set; }
        public virtual ICollection<CoreStoreGroup> CoreStoreGroup { get; set; }
        public virtual ICollection<CustomerEavAttributeWebsite> CustomerEavAttributeWebsite { get; set; }
        public virtual ICollection<CustomerEntity> CustomerEntity { get; set; }
        public virtual ICollection<DownloadableLinkPrice> DownloadableLinkPrice { get; set; }
        public virtual ICollection<PaypalCert> PaypalCert { get; set; }
        public virtual ICollection<PersistentSession> PersistentSession { get; set; }
        public virtual ICollection<ProductAlertPrice> ProductAlertPrice { get; set; }
        public virtual ICollection<ProductAlertStock> ProductAlertStock { get; set; }
        public virtual ICollection<SalesruleProductAttribute> SalesruleProductAttribute { get; set; }
        public virtual ICollection<SalesruleWebsite> SalesruleWebsite { get; set; }
        public virtual ICollection<WeeeTax> WeeeTax { get; set; }
    }
}
