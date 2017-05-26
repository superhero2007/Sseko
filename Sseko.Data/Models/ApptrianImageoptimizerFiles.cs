using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class ApptrianImageoptimizerFiles
    {
        public string Id { get; set; }
        public string FilePath { get; set; }
        public int NewFileSize { get; set; }
        public int OldFileSize { get; set; }
        public int OptimizationTime { get; set; }
        public bool Optimized { get; set; }
    }
}
