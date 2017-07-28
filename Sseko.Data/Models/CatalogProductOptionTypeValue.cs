using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductOptionTypeValue
    {
        public CatalogProductOptionTypeValue()
        {
            CatalogProductOptionTypePrice = new HashSet<CatalogProductOptionTypePrice>();
            CatalogProductOptionTypeTitle = new HashSet<CatalogProductOptionTypeTitle>();
        }

        public int OptionTypeId { get; set; }
        public int OptionId { get; set; }
        public string Sku { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<CatalogProductOptionTypePrice> CatalogProductOptionTypePrice { get; set; }
        public virtual ICollection<CatalogProductOptionTypeTitle> CatalogProductOptionTypeTitle { get; set; }
        public virtual CatalogProductOption Option { get; set; }
    }
}
