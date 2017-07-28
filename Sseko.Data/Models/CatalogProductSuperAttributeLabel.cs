namespace Sseko.Data.Models
{
    public partial class CatalogProductSuperAttributeLabel
    {
        public int ValueId { get; set; }
        public int ProductSuperAttributeId { get; set; }
        public ushort StoreId { get; set; }
        public ushort? UseDefault { get; set; }
        public string Value { get; set; }

        public virtual CatalogProductSuperAttribute ProductSuperAttribute { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
