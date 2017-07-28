using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaTemplate
    {
        public MRmaTemplate()
        {
            MRmaTemplateStore = new HashSet<MRmaTemplateStore>();
        }

        public int TemplateId { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string Template { get; set; }

        public virtual ICollection<MRmaTemplateStore> MRmaTemplateStore { get; set; }
    }
}
