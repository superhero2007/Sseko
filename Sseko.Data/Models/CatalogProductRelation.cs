namespace Sseko.Data.Models
{
    public partial class CatalogProductRelation
    {
        public int ParentId { get; set; }
        public int ChildId { get; set; }

        public virtual CatalogProductEntity Child { get; set; }
        public virtual CatalogProductEntity Parent { get; set; }
    }
}
