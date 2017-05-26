using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class WidgetInstancePage
    {
        public WidgetInstancePage()
        {
            WidgetInstancePageLayout = new HashSet<WidgetInstancePageLayout>();
        }

        public int PageId { get; set; }
        public string BlockReference { get; set; }
        public string Entities { get; set; }
        public int InstanceId { get; set; }
        public string LayoutHandle { get; set; }
        public string PageFor { get; set; }
        public string PageGroup { get; set; }
        public string PageTemplate { get; set; }

        public virtual ICollection<WidgetInstancePageLayout> WidgetInstancePageLayout { get; set; }
        public virtual WidgetInstance Instance { get; set; }
    }
}
