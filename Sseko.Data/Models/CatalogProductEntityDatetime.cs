using System;

namespace Sseko.Data.Models
{
    public partial class CatalogProductEntityDatetime
    {
        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public ushort EntityTypeId { get; set; }
        public ushort StoreId { get; set; }
        public DateTime? Value { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
