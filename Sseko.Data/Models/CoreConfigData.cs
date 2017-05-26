using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreConfigData
    {
        public int ConfigId { get; set; }
        public string Path { get; set; }
        public string Scope { get; set; }
        public int ScopeId { get; set; }
        public string Value { get; set; }
    }
}
