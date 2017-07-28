namespace Sseko.Data.Models
{
    public partial class CmsPageStore
    {
        public short PageId { get; set; }
        public ushort StoreId { get; set; }

        public virtual CmsPage Page { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
