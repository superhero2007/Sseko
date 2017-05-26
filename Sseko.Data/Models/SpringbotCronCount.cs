using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class SpringbotCronCount
    {
        public int Id { get; set; }
        public DateTime? Completed { get; set; }
        public int Count { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Entity { get; set; }
        public string HarvestId { get; set; }
        public int StoreId { get; set; }
    }
}
