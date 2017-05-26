using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class TagRelation
    {
        public int TagRelationId { get; set; }
        public ushort Active { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CustomerId { get; set; }
        public int ProductId { get; set; }
        public ushort StoreId { get; set; }
        public int TagId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
        public virtual CoreStore Store { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
