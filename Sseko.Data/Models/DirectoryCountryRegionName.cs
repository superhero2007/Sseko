using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DirectoryCountryRegionName
    {
        public string Locale { get; set; }
        public int RegionId { get; set; }
        public string Name { get; set; }

        public virtual DirectoryCountryRegion Region { get; set; }
    }
}
