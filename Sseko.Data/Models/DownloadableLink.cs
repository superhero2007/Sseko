using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DownloadableLink
    {
        public DownloadableLink()
        {
            DownloadableLinkPrice = new HashSet<DownloadableLinkPrice>();
            DownloadableLinkTitle = new HashSet<DownloadableLinkTitle>();
        }

        public int LinkId { get; set; }
        public ushort IsShareable { get; set; }
        public string LinkFile { get; set; }
        public string LinkType { get; set; }
        public string LinkUrl { get; set; }
        public int? NumberOfDownloads { get; set; }
        public int ProductId { get; set; }
        public string SampleFile { get; set; }
        public string SampleType { get; set; }
        public string SampleUrl { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<DownloadableLinkPrice> DownloadableLinkPrice { get; set; }
        public virtual ICollection<DownloadableLinkTitle> DownloadableLinkTitle { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
