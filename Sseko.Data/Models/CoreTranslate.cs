using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreTranslate
    {
        public int KeyId { get; set; }
        public long CrcString { get; set; }
        public string Locale { get; set; }
        public ushort StoreId { get; set; }
        public string String { get; set; }
        public string Translate { get; set; }

        public virtual CoreStore Store { get; set; }
    }
}
