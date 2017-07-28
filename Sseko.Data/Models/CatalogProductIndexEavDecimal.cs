namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexEavDecimal
    {
        public int EntityId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort StoreId { get; set; }
        public decimal Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
