using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductEntityGallery
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public int Position { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
