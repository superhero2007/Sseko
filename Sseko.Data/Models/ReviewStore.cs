namespace Sseko.Data.Models
{
    public partial class ReviewStore
    {
        public ulong ReviewId { get; set; }
        public ushort StoreId { get; set; }

        public virtual Review Review { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
