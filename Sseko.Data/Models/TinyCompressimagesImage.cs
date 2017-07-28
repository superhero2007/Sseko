using System;

namespace Sseko.Data.Models
{
    public partial class TinyCompressimagesImage
    {
        public int ImageId { get; set; }
        public int BytesAfter { get; set; }
        public int BytesBefore { get; set; }
        public int? CompressedBefore { get; set; }
        public string HashAfter { get; set; }
        public string HashBefore { get; set; }
        public string ImageType { get; set; }
        public int IsTest { get; set; }
        public int? ParentId { get; set; }
        public string Path { get; set; }
        public string PathOptimized { get; set; }
        public DateTime ProcessedAt { get; set; }
        public int UsedAsSource { get; set; }
    }
}
