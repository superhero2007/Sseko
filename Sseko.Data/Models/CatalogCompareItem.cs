namespace Sseko.Data.Models
{
    public partial class CatalogCompareItem
    {
        public int CatalogCompareItemId { get; set; }
        public int? CustomerId { get; set; }
        public int ProductId { get; set; }
        public ushort? StoreId { get; set; }
        public int VisitorId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
