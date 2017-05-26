using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductIndexEavTmp
    {
        public int EntityId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort StoreId { get; set; }
        public int Value { get; set; }
    }
}
