namespace Sseko.Data.Models
{
    public partial class MRmaRmaStore
    {
        public int RmaStoreId { get; set; }
        public int RsRmaId { get; set; }
        public ushort RsStoreId { get; set; }

        public virtual MRmaRma RsRma { get; set; }
        public virtual CoreStore RsStore { get; set; }
    }
}
