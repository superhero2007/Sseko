namespace Sseko.Data.Models
{
    public partial class CmsBlockStore
    {
        public short BlockId { get; set; }
        public ushort StoreId { get; set; }

        public virtual CmsBlock Block { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
