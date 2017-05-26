using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductEntityMediaGalleryValue
    {
        public int ValueId { get; set; }
        public ushort StoreId { get; set; }
        public ushort Disabled { get; set; }
        public string Label { get; set; }
        public int? Position { get; set; }

        public virtual CoreStore Store { get; set; }
        public virtual CatalogProductEntityMediaGallery Value { get; set; }
    }
}
