using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MMstcoreAttachment
    {
        public int AttachmentId { get; set; }
        public byte[] Body { get; set; }
        public int? EntityId { get; set; }
        public string EntityType { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public string Type { get; set; }
        public string Uid { get; set; }
    }
}
