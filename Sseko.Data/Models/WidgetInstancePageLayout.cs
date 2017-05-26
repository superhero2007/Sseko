using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class WidgetInstancePageLayout
    {
        public int PageId { get; set; }
        public int LayoutUpdateId { get; set; }

        public virtual CoreLayoutUpdate LayoutUpdate { get; set; }
        public virtual WidgetInstancePage Page { get; set; }
    }
}
