namespace Sseko.Data.Models
{
    public partial class CatalogProductSuperLink
    {
        public int LinkId { get; set; }
        public int ParentId { get; set; }
        public int ProductId { get; set; }

        public virtual CatalogProductEntity Parent { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
