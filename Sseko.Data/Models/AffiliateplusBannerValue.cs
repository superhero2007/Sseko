using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusBannerValue
    {
        public int ValueId { get; set; }
        public string AttributeCode { get; set; }
        public int BannerId { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual AffiliateplusBanner Banner { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
