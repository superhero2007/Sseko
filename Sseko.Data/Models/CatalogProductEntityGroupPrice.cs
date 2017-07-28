namespace Sseko.Data.Models
{
    public partial class CatalogProductEntityGroupPrice
    {
        public int ValueId { get; set; }
        public ushort AllGroups { get; set; }
        public ushort CustomerGroupId { get; set; }
        public int EntityId { get; set; }
        public decimal Value { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
