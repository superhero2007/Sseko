using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavEntity
    {
        public EavEntity()
        {
            EavEntityDatetime = new HashSet<EavEntityDatetime>();
            EavEntityDecimal = new HashSet<EavEntityDecimal>();
            EavEntityInt = new HashSet<EavEntityInt>();
            EavEntityText = new HashSet<EavEntityText>();
            EavEntityVarchar = new HashSet<EavEntityVarchar>();
        }

        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort EntityTypeId { get; set; }
        public string IncrementId { get; set; }
        public ushort IsActive { get; set; }
        public int ParentId { get; set; }
        public ushort StoreId { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<EavEntityDatetime> EavEntityDatetime { get; set; }
        public virtual ICollection<EavEntityDecimal> EavEntityDecimal { get; set; }
        public virtual ICollection<EavEntityInt> EavEntityInt { get; set; }
        public virtual ICollection<EavEntityText> EavEntityText { get; set; }
        public virtual ICollection<EavEntityVarchar> EavEntityVarchar { get; set; }
        public virtual EavEntityType EntityType { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
