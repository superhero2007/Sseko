using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogruleWebsite
    {
        public int RuleId { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual Catalogrule Rule { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
