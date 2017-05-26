using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DirectoryCountry
    {
        public DirectoryCountry()
        {
            WeeeTax = new HashSet<WeeeTax>();
        }

        public string CountryId { get; set; }
        public string Iso2Code { get; set; }
        public string Iso3Code { get; set; }

        public virtual ICollection<WeeeTax> WeeeTax { get; set; }
    }
}
