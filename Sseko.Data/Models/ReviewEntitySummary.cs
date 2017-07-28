namespace Sseko.Data.Models
{
    public partial class ReviewEntitySummary
    {
        public long PrimaryId { get; set; }
        public long EntityPkValue { get; set; }
        public short EntityType { get; set; }
        public short RatingSummary { get; set; }
        public short ReviewsCount { get; set; }
        public ushort StoreId { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
