using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaFedexLabel
    {
        public int LabelId { get; set; }
        public byte[] LabelBody { get; set; }
        public DateTime? LabelDate { get; set; }
        public int? PackageNumber { get; set; }
        public int RmaId { get; set; }
        public string TrackNumber { get; set; }

        public virtual MRmaRma Rma { get; set; }
    }
}
