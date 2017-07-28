namespace Sseko.Data.Models
{
    public partial class ReviewDetail
    {
        public ulong DetailId { get; set; }
        public int? CustomerId { get; set; }
        public string Detail { get; set; }
        public string Nickname { get; set; }
        public ulong ReviewId { get; set; }
        public ushort? StoreId { get; set; }
        public string Title { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual Review Review { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
