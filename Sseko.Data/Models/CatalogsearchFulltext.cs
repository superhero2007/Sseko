namespace Sseko.Data.Models
{
    public partial class CatalogsearchFulltext
    {
        public int FulltextId { get; set; }
        public string DataIndex { get; set; }
        public int ProductId { get; set; }
        public ushort StoreId { get; set; }
    }
}
