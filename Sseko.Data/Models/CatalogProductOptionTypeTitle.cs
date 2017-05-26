using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductOptionTypeTitle
    {
        public int OptionTypeTitleId { get; set; }
        public int OptionTypeId { get; set; }
        public ushort StoreId { get; set; }
        public string Title { get; set; }

        public virtual CatalogProductOptionTypeValue OptionType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
