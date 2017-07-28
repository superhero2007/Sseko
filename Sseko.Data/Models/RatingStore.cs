namespace Sseko.Data.Models
{
    public partial class RatingStore
    {
        public ushort RatingId { get; set; }
        public ushort StoreId { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
