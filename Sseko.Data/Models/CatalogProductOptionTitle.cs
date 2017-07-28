namespace Sseko.Data.Models
{
    public partial class CatalogProductOptionTitle
    {
        public int OptionTitleId { get; set; }
        public int OptionId { get; set; }
        public ushort StoreId { get; set; }
        public string Title { get; set; }

        public virtual CatalogProductOption Option { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
