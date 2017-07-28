using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavEntityType
    {
        public EavEntityType()
        {
            CatalogProductEntity = new HashSet<CatalogProductEntity>();
            CustomerAddressEntityDatetime = new HashSet<CustomerAddressEntityDatetime>();
            CustomerAddressEntityDecimal = new HashSet<CustomerAddressEntityDecimal>();
            CustomerAddressEntityInt = new HashSet<CustomerAddressEntityInt>();
            CustomerAddressEntityText = new HashSet<CustomerAddressEntityText>();
            CustomerAddressEntityVarchar = new HashSet<CustomerAddressEntityVarchar>();
            CustomerEntityDatetime = new HashSet<CustomerEntityDatetime>();
            CustomerEntityDecimal = new HashSet<CustomerEntityDecimal>();
            CustomerEntityInt = new HashSet<CustomerEntityInt>();
            CustomerEntityText = new HashSet<CustomerEntityText>();
            CustomerEntityVarchar = new HashSet<CustomerEntityVarchar>();
            EavAttribute = new HashSet<EavAttribute>();
            EavAttributeSet = new HashSet<EavAttributeSet>();
            EavEntity = new HashSet<EavEntity>();
            EavEntityDatetime = new HashSet<EavEntityDatetime>();
            EavEntityDecimal = new HashSet<EavEntityDecimal>();
            EavEntityInt = new HashSet<EavEntityInt>();
            EavEntityStore = new HashSet<EavEntityStore>();
            EavEntityText = new HashSet<EavEntityText>();
            EavEntityVarchar = new HashSet<EavEntityVarchar>();
            EavFormTypeEntity = new HashSet<EavFormTypeEntity>();
        }

        public ushort EntityTypeId { get; set; }
        public string AdditionalAttributeTable { get; set; }
        public string AttributeModel { get; set; }
        public string DataSharingKey { get; set; }
        public ushort DefaultAttributeSetId { get; set; }
        public string EntityAttributeCollection { get; set; }
        public string EntityIdField { get; set; }
        public string EntityModel { get; set; }
        public string EntityTable { get; set; }
        public string EntityTypeCode { get; set; }
        public string IncrementModel { get; set; }
        public string IncrementPadChar { get; set; }
        public ushort IncrementPadLength { get; set; }
        public ushort IncrementPerStore { get; set; }
        public ushort IsDataSharing { get; set; }
        public string ValueTablePrefix { get; set; }

        public virtual ICollection<CatalogProductEntity> CatalogProductEntity { get; set; }
        public virtual ICollection<CustomerAddressEntityDatetime> CustomerAddressEntityDatetime { get; set; }
        public virtual ICollection<CustomerAddressEntityDecimal> CustomerAddressEntityDecimal { get; set; }
        public virtual ICollection<CustomerAddressEntityInt> CustomerAddressEntityInt { get; set; }
        public virtual ICollection<CustomerAddressEntityText> CustomerAddressEntityText { get; set; }
        public virtual ICollection<CustomerAddressEntityVarchar> CustomerAddressEntityVarchar { get; set; }
        public virtual ICollection<CustomerEntityDatetime> CustomerEntityDatetime { get; set; }
        public virtual ICollection<CustomerEntityDecimal> CustomerEntityDecimal { get; set; }
        public virtual ICollection<CustomerEntityInt> CustomerEntityInt { get; set; }
        public virtual ICollection<CustomerEntityText> CustomerEntityText { get; set; }
        public virtual ICollection<CustomerEntityVarchar> CustomerEntityVarchar { get; set; }
        public virtual ICollection<EavAttribute> EavAttribute { get; set; }
        public virtual ICollection<EavAttributeSet> EavAttributeSet { get; set; }
        public virtual ICollection<EavEntity> EavEntity { get; set; }
        public virtual ICollection<EavEntityDatetime> EavEntityDatetime { get; set; }
        public virtual ICollection<EavEntityDecimal> EavEntityDecimal { get; set; }
        public virtual ICollection<EavEntityInt> EavEntityInt { get; set; }
        public virtual ICollection<EavEntityStore> EavEntityStore { get; set; }
        public virtual ICollection<EavEntityText> EavEntityText { get; set; }
        public virtual ICollection<EavEntityVarchar> EavEntityVarchar { get; set; }
        public virtual ICollection<EavFormTypeEntity> EavFormTypeEntity { get; set; }
    }
}
