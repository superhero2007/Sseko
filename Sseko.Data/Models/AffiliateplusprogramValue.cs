namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramValue
    {
        public int ValueId { get; set; }
        public string AttributeCode { get; set; }
        public int ProgramId { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual Affiliateplusprogram Program { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
