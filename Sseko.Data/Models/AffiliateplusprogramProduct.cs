namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProgramId { get; set; }
        public ushort StoreId { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual Affiliateplusprogram Program { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
