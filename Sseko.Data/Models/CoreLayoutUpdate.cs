using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreLayoutUpdate
    {
        public CoreLayoutUpdate()
        {
            CoreLayoutLink = new HashSet<CoreLayoutLink>();
            WidgetInstancePageLayout = new HashSet<WidgetInstancePageLayout>();
        }

        public int LayoutUpdateId { get; set; }
        public string Handle { get; set; }
        public short SortOrder { get; set; }
        public string Xml { get; set; }

        public virtual ICollection<CoreLayoutLink> CoreLayoutLink { get; set; }
        public virtual ICollection<WidgetInstancePageLayout> WidgetInstancePageLayout { get; set; }
    }
}
