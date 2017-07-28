using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class WidgetInstance
    {
        public WidgetInstance()
        {
            WidgetInstancePage = new HashSet<WidgetInstancePage>();
        }

        public int InstanceId { get; set; }
        public string InstanceType { get; set; }
        public string PackageTheme { get; set; }
        public ushort SortOrder { get; set; }
        public string StoreIds { get; set; }
        public string Title { get; set; }
        public string WidgetParameters { get; set; }

        public virtual ICollection<WidgetInstancePage> WidgetInstancePage { get; set; }
    }
}
