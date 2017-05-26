using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DirectoryCountryRegion
    {
        public DirectoryCountryRegion()
        {
            DirectoryCountryRegionName = new HashSet<DirectoryCountryRegionName>();
        }

        public int RegionId { get; set; }
        public string Code { get; set; }
        public string CountryId { get; set; }
        public string DefaultName { get; set; }

        public virtual ICollection<DirectoryCountryRegionName> DirectoryCountryRegionName { get; set; }
    }
}
