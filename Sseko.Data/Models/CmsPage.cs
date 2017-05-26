using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CmsPage
    {
        public CmsPage()
        {
            CmsPageStore = new HashSet<CmsPageStore>();
        }

        public short PageId { get; set; }
        public string Content { get; set; }
        public string ContentHeading { get; set; }
        public DateTime? CreationTime { get; set; }
        public string CustomLayoutUpdateXml { get; set; }
        public string CustomRootTemplate { get; set; }
        public string CustomTheme { get; set; }
        public DateTime? CustomThemeFrom { get; set; }
        public DateTime? CustomThemeTo { get; set; }
        public string Identifier { get; set; }
        public short IsActive { get; set; }
        public string LayoutUpdateXml { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string RootTemplate { get; set; }
        public short SortOrder { get; set; }
        public string Title { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<CmsPageStore> CmsPageStore { get; set; }
    }
}
