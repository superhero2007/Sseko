namespace Sseko.Data.Models
{
    public partial class CatalogProductLinkAttributeDecimal
    {
        public int ValueId { get; set; }
        public int LinkId { get; set; }
        public ushort? ProductLinkAttributeId { get; set; }
        public decimal Value { get; set; }

        public virtual CatalogProductLink Link { get; set; }
        public virtual CatalogProductLinkAttribute ProductLinkAttribute { get; set; }
    }
}
