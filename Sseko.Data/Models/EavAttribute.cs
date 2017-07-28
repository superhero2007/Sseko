using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavAttribute
    {
        public EavAttribute()
        {
            CatalogCategoryEntityDatetime = new HashSet<CatalogCategoryEntityDatetime>();
            CatalogCategoryEntityDecimal = new HashSet<CatalogCategoryEntityDecimal>();
            CatalogCategoryEntityInt = new HashSet<CatalogCategoryEntityInt>();
            CatalogCategoryEntityText = new HashSet<CatalogCategoryEntityText>();
            CatalogCategoryEntityVarchar = new HashSet<CatalogCategoryEntityVarchar>();
            CatalogProductEntityDatetime = new HashSet<CatalogProductEntityDatetime>();
            CatalogProductEntityDecimal = new HashSet<CatalogProductEntityDecimal>();
            CatalogProductEntityGallery = new HashSet<CatalogProductEntityGallery>();
            CatalogProductEntityInt = new HashSet<CatalogProductEntityInt>();
            CatalogProductEntityMediaGallery = new HashSet<CatalogProductEntityMediaGallery>();
            CatalogProductEntityText = new HashSet<CatalogProductEntityText>();
            CatalogProductEntityVarchar = new HashSet<CatalogProductEntityVarchar>();
            CatalogProductIndexEav = new HashSet<CatalogProductIndexEav>();
            CatalogProductIndexEavDecimal = new HashSet<CatalogProductIndexEavDecimal>();
            CustomerAddressEntityDatetime = new HashSet<CustomerAddressEntityDatetime>();
            CustomerAddressEntityDecimal = new HashSet<CustomerAddressEntityDecimal>();
            CustomerAddressEntityInt = new HashSet<CustomerAddressEntityInt>();
            CustomerAddressEntityText = new HashSet<CustomerAddressEntityText>();
            CustomerAddressEntityVarchar = new HashSet<CustomerAddressEntityVarchar>();
            CustomerEavAttributeWebsite = new HashSet<CustomerEavAttributeWebsite>();
            CustomerEntityDatetime = new HashSet<CustomerEntityDatetime>();
            CustomerEntityDecimal = new HashSet<CustomerEntityDecimal>();
            CustomerEntityInt = new HashSet<CustomerEntityInt>();
            CustomerEntityText = new HashSet<CustomerEntityText>();
            CustomerEntityVarchar = new HashSet<CustomerEntityVarchar>();
            CustomerFormAttribute = new HashSet<CustomerFormAttribute>();
            EavAttributeLabel = new HashSet<EavAttributeLabel>();
            EavAttributeOption = new HashSet<EavAttributeOption>();
            EavEntityAttribute = new HashSet<EavEntityAttribute>();
            EavFormElement = new HashSet<EavFormElement>();
            SalesruleProductAttribute = new HashSet<SalesruleProductAttribute>();
            WeeeTax = new HashSet<WeeeTax>();
        }

        public ushort AttributeId { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeModel { get; set; }
        public string BackendModel { get; set; }
        public string BackendTable { get; set; }
        public string BackendType { get; set; }
        public string DefaultValue { get; set; }
        public ushort EntityTypeId { get; set; }
        public string FrontendClass { get; set; }
        public string FrontendInput { get; set; }
        public string FrontendLabel { get; set; }
        public string FrontendModel { get; set; }
        public ushort IsRequired { get; set; }
        public ushort IsUnique { get; set; }
        public ushort IsUserDefined { get; set; }
        public string Note { get; set; }
        public string SourceModel { get; set; }

        public virtual ICollection<CatalogCategoryEntityDatetime> CatalogCategoryEntityDatetime { get; set; }
        public virtual ICollection<CatalogCategoryEntityDecimal> CatalogCategoryEntityDecimal { get; set; }
        public virtual ICollection<CatalogCategoryEntityInt> CatalogCategoryEntityInt { get; set; }
        public virtual ICollection<CatalogCategoryEntityText> CatalogCategoryEntityText { get; set; }
        public virtual ICollection<CatalogCategoryEntityVarchar> CatalogCategoryEntityVarchar { get; set; }
        public virtual CatalogEavAttribute CatalogEavAttribute { get; set; }
        public virtual ICollection<CatalogProductEntityDatetime> CatalogProductEntityDatetime { get; set; }
        public virtual ICollection<CatalogProductEntityDecimal> CatalogProductEntityDecimal { get; set; }
        public virtual ICollection<CatalogProductEntityGallery> CatalogProductEntityGallery { get; set; }
        public virtual ICollection<CatalogProductEntityInt> CatalogProductEntityInt { get; set; }
        public virtual ICollection<CatalogProductEntityMediaGallery> CatalogProductEntityMediaGallery { get; set; }
        public virtual ICollection<CatalogProductEntityText> CatalogProductEntityText { get; set; }
        public virtual ICollection<CatalogProductEntityVarchar> CatalogProductEntityVarchar { get; set; }
        public virtual ICollection<CatalogProductIndexEav> CatalogProductIndexEav { get; set; }
        public virtual ICollection<CatalogProductIndexEavDecimal> CatalogProductIndexEavDecimal { get; set; }
        public virtual ICollection<CustomerAddressEntityDatetime> CustomerAddressEntityDatetime { get; set; }
        public virtual ICollection<CustomerAddressEntityDecimal> CustomerAddressEntityDecimal { get; set; }
        public virtual ICollection<CustomerAddressEntityInt> CustomerAddressEntityInt { get; set; }
        public virtual ICollection<CustomerAddressEntityText> CustomerAddressEntityText { get; set; }
        public virtual ICollection<CustomerAddressEntityVarchar> CustomerAddressEntityVarchar { get; set; }
        public virtual CustomerEavAttribute CustomerEavAttribute { get; set; }
        public virtual ICollection<CustomerEavAttributeWebsite> CustomerEavAttributeWebsite { get; set; }
        public virtual ICollection<CustomerEntityDatetime> CustomerEntityDatetime { get; set; }
        public virtual ICollection<CustomerEntityDecimal> CustomerEntityDecimal { get; set; }
        public virtual ICollection<CustomerEntityInt> CustomerEntityInt { get; set; }
        public virtual ICollection<CustomerEntityText> CustomerEntityText { get; set; }
        public virtual ICollection<CustomerEntityVarchar> CustomerEntityVarchar { get; set; }
        public virtual ICollection<CustomerFormAttribute> CustomerFormAttribute { get; set; }
        public virtual ICollection<EavAttributeLabel> EavAttributeLabel { get; set; }
        public virtual ICollection<EavAttributeOption> EavAttributeOption { get; set; }
        public virtual ICollection<EavEntityAttribute> EavEntityAttribute { get; set; }
        public virtual ICollection<EavFormElement> EavFormElement { get; set; }
        public virtual ICollection<SalesruleProductAttribute> SalesruleProductAttribute { get; set; }
        public virtual ICollection<WeeeTax> WeeeTax { get; set; }
        public virtual EavEntityType EntityType { get; set; }
    }
}
