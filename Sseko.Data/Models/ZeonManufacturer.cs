using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ZeonManufacturer
    {
        public ZeonManufacturer()
        {
            ZeonManufacturerStore = new HashSet<ZeonManufacturerStore>();
        }

        public int ManufacturerId { get; set; }
        public DateTime? CreationTime { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public short IsDisplayHome { get; set; }
        public int Manufacturer { get; set; }
        public string ManufacturerBanner { get; set; }
        public string ManufacturerLogo { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public short? SortOrder { get; set; }
        public short Status { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<ZeonManufacturerStore> ZeonManufacturerStore { get; set; }
        public virtual EavAttributeOption ManufacturerNavigation { get; set; }
    }
}
