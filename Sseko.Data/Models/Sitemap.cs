using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Sitemap
    {
        public int SitemapId { get; set; }
        public string SitemapFilename { get; set; }
        public string SitemapPath { get; set; }
        public DateTime? SitemapTime { get; set; }
        public string SitemapType { get; set; }
        public ushort StoreId { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
