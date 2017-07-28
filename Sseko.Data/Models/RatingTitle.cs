namespace Sseko.Data.Models
{
    public partial class RatingTitle
    {
        public ushort RatingId { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
