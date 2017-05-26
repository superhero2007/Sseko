using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreLayoutLink
    {
        public int LayoutLinkId { get; set; }
        public string Area { get; set; }
        public int LayoutUpdateId { get; set; }
        public string Package { get; set; }
        public ushort StoreId { get; set; }
        public string Theme { get; set; }

        public virtual CoreLayoutUpdate LayoutUpdate { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
