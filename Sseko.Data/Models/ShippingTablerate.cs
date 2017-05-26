using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ShippingTablerate
    {
        public int Pk { get; set; }
        public string ConditionName { get; set; }
        public decimal ConditionValue { get; set; }
        public decimal Cost { get; set; }
        public string DestCountryId { get; set; }
        public int DestRegionId { get; set; }
        public string DestZip { get; set; }
        public decimal Price { get; set; }
        public int WebsiteId { get; set; }
    }
}
