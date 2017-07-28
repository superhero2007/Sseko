namespace Sseko.Data.Models
{
    public partial class CatalogProductBundleOptionValue
    {
        public int ValueId { get; set; }
        public int OptionId { get; set; }
        public ushort StoreId { get; set; }
        public string Title { get; set; }

        public virtual CatalogProductBundleOption Option { get; set; }
    }
}
