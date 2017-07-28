namespace Sseko.Data.Models
{
    public partial class PollStore
    {
        public int PollId { get; set; }
        public ushort StoreId { get; set; }

        public virtual Poll Poll { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
