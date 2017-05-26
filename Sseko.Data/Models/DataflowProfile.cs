using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class DataflowProfile
    {
        public DataflowProfile()
        {
            DataflowBatch = new HashSet<DataflowBatch>();
            DataflowProfileHistory = new HashSet<DataflowProfileHistory>();
        }

        public int ProfileId { get; set; }
        public string ActionsXml { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string DataTransfer { get; set; }
        public string Direction { get; set; }
        public string EntityType { get; set; }
        public string GuiData { get; set; }
        public string Name { get; set; }
        public ushort StoreId { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<DataflowBatch> DataflowBatch { get; set; }
        public virtual ICollection<DataflowProfileHistory> DataflowProfileHistory { get; set; }
    }
}
