namespace Sseko.Data.Models
{
    public partial class AffiliatepluslevelTier
    {
        public int Id { get; set; }
        public byte Level { get; set; }
        public int TierId { get; set; }
        public int ToptierId { get; set; }

        public virtual AffiliateplusAccount Tier { get; set; }
        public virtual AffiliateplusAccount Toptier { get; set; }
    }
}
