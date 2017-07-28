namespace Sseko.Data.Models
{
    public partial class WeeeTax
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public string Country { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public string State { get; set; }
        public decimal Value { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual DirectoryCountry CountryNavigation { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
