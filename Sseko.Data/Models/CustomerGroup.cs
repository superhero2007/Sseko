using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerGroup
    {
        public CustomerGroup()
        {
            CatalogProductBundlePriceIndex = new HashSet<CatalogProductBundlePriceIndex>();
            CatalogProductEntityGroupPrice = new HashSet<CatalogProductEntityGroupPrice>();
            CatalogProductEntityTierPrice = new HashSet<CatalogProductEntityTierPrice>();
            CatalogProductIndexGroupPrice = new HashSet<CatalogProductIndexGroupPrice>();
            CatalogProductIndexPrice = new HashSet<CatalogProductIndexPrice>();
            CatalogProductIndexTierPrice = new HashSet<CatalogProductIndexTierPrice>();
            CatalogruleCustomerGroup = new HashSet<CatalogruleCustomerGroup>();
            CatalogruleGroupWebsite = new HashSet<CatalogruleGroupWebsite>();
            CatalogruleProduct = new HashSet<CatalogruleProduct>();
            CatalogruleProductPrice = new HashSet<CatalogruleProductPrice>();
            SalesruleCustomerGroup = new HashSet<SalesruleCustomerGroup>();
            SalesruleProductAttribute = new HashSet<SalesruleProductAttribute>();
        }

        public ushort CustomerGroupId { get; set; }
        public string CustomerGroupCode { get; set; }
        public int TaxClassId { get; set; }

        public virtual ICollection<CatalogProductBundlePriceIndex> CatalogProductBundlePriceIndex { get; set; }
        public virtual ICollection<CatalogProductEntityGroupPrice> CatalogProductEntityGroupPrice { get; set; }
        public virtual ICollection<CatalogProductEntityTierPrice> CatalogProductEntityTierPrice { get; set; }
        public virtual ICollection<CatalogProductIndexGroupPrice> CatalogProductIndexGroupPrice { get; set; }
        public virtual ICollection<CatalogProductIndexPrice> CatalogProductIndexPrice { get; set; }
        public virtual ICollection<CatalogProductIndexTierPrice> CatalogProductIndexTierPrice { get; set; }
        public virtual ICollection<CatalogruleCustomerGroup> CatalogruleCustomerGroup { get; set; }
        public virtual ICollection<CatalogruleGroupWebsite> CatalogruleGroupWebsite { get; set; }
        public virtual ICollection<CatalogruleProduct> CatalogruleProduct { get; set; }
        public virtual ICollection<CatalogruleProductPrice> CatalogruleProductPrice { get; set; }
        public virtual ICollection<SalesruleCustomerGroup> SalesruleCustomerGroup { get; set; }
        public virtual ICollection<SalesruleProductAttribute> SalesruleProductAttribute { get; set; }
    }
}
