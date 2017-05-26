using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Api2AclAttribute
    {
        public int EntityId { get; set; }
        public string AllowedAttributes { get; set; }
        public string Operation { get; set; }
        public string ResourceId { get; set; }
        public string UserType { get; set; }
    }
}
