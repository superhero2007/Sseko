using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class OnestepcheckoutDelivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryTimeDate { get; set; }
        public int OrderId { get; set; }
    }
}
