using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class AffiliateplusBanner
    {
        public AffiliateplusBanner()
        {
            AffiliateplusBannerValue = new HashSet<AffiliateplusBannerValue>();
        }

        public int BannerId { get; set; }
        public int Height { get; set; }
        public string Link { get; set; }
        public int ProgramId { get; set; }
        public short RelNofollow { get; set; }
        public string SourceFile { get; set; }
        public bool Status { get; set; }
        public string Title { get; set; }
        public bool TypeId { get; set; }
        public int Width { get; set; }

        public virtual ICollection<AffiliateplusBannerValue> AffiliateplusBannerValue { get; set; }
    }
}
