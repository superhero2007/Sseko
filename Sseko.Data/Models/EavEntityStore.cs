using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavEntityStore
    {
        public int EntityStoreId { get; set; }
        public ushort EntityTypeId { get; set; }
        public string IncrementLastId { get; set; }
        public string IncrementPrefix { get; set; }
        public ushort StoreId { get; set; }

        public virtual EavEntityType EntityType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
