using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreFlag
    {
        public int FlagId { get; set; }
        public string FlagCode { get; set; }
        public string FlagData { get; set; }
        public DateTime LastUpdate { get; set; }
        public ushort State { get; set; }
    }
}
