using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexEavDecimalIdx
    {
        public int EntityId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort StoreId { get; set; }
        public decimal Value { get; set; }
    }
}
