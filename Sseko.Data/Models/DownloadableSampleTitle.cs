using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DownloadableSampleTitle
    {
        public int TitleId { get; set; }
        public int SampleId { get; set; }
        public ushort StoreId { get; set; }
        public string Title { get; set; }

        public virtual DownloadableSample Sample { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
