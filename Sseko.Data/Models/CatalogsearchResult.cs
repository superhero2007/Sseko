namespace Sseko.Data.Models
{
    public partial class CatalogsearchResult
    {
        public int QueryId { get; set; }
        public int ProductId { get; set; }
        public decimal Relevance { get; set; }

        public virtual CatalogProductEntity Product { get; set; }
        public virtual CatalogsearchQuery Query { get; set; }
    }
}
