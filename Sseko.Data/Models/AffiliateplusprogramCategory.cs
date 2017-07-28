namespace Sseko.Data.Models
{
    public partial class AffiliateplusprogramCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProgramId { get; set; }
        public ushort StoreId { get; set; }

        public virtual CatalogCategoryEntity Category { get; set; }
        public virtual Affiliateplusprogram Program { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
