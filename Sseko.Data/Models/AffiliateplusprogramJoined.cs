namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramJoined
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ProgramId { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
        public virtual Affiliateplusprogram Program { get; set; }
    }
}
