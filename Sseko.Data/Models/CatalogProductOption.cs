using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductOption
    {
        public CatalogProductOption()
        {
            CatalogProductOptionPrice = new HashSet<CatalogProductOptionPrice>();
            CatalogProductOptionTitle = new HashSet<CatalogProductOptionTitle>();
            CatalogProductOptionTypeValue = new HashSet<CatalogProductOptionTypeValue>();
        }

        public int OptionId { get; set; }
        public string FileExtension { get; set; }
        public ushort? ImageSizeX { get; set; }
        public ushort? ImageSizeY { get; set; }
        public short IsRequire { get; set; }
        public int? MaxCharacters { get; set; }
        public int ProductId { get; set; }
        public string Sku { get; set; }
        public int SortOrder { get; set; }
        public string Type { get; set; }

        public virtual ICollection<CatalogProductOptionPrice> CatalogProductOptionPrice { get; set; }
        public virtual ICollection<CatalogProductOptionTitle> CatalogProductOptionTitle { get; set; }
        public virtual ICollection<CatalogProductOptionTypeValue> CatalogProductOptionTypeValue { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
