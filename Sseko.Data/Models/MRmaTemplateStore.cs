using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaTemplateStore
    {
        public int TemplateStoreId { get; set; }
        public ushort TsStoreId { get; set; }
        public int TsTemplateId { get; set; }

        public virtual CoreStore TsStore { get; set; }
        public virtual MRmaTemplate TsTemplate { get; set; }
    }
}
