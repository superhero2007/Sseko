using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusAccountValue
    {
        public int ValueId { get; set; }
        public int AccountId { get; set; }
        public string AttributeCode { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
