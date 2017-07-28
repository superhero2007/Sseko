namespace Sseko.Data.Models
{
    public partial class CatalogProductEnabledIndex
    {
        public int ProductId { get; set; }
        public ushort StoreId { get; set; }
        public ushort Visibility { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
