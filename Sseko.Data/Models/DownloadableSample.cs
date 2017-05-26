using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DownloadableSample
    {
        public DownloadableSample()
        {
            DownloadableSampleTitle = new HashSet<DownloadableSampleTitle>();
        }

        public int SampleId { get; set; }
        public int ProductId { get; set; }
        public string SampleFile { get; set; }
        public string SampleType { get; set; }
        public string SampleUrl { get; set; }
        public int SortOrder { get; set; }

        public virtual ICollection<DownloadableSampleTitle> DownloadableSampleTitle { get; set; }
        public virtual CatalogProductEntity Product { get; set; }
    }
}
