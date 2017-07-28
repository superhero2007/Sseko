using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavFormType
    {
        public EavFormType()
        {
            EavFormElement = new HashSet<EavFormElement>();
            EavFormFieldset = new HashSet<EavFormFieldset>();
            EavFormTypeEntity = new HashSet<EavFormTypeEntity>();
        }

        public ushort TypeId { get; set; }
        public string Code { get; set; }
        public ushort IsSystem { get; set; }
        public string Label { get; set; }
        public ushort StoreId { get; set; }
        public string Theme { get; set; }

        public virtual ICollection<EavFormElement> EavFormElement { get; set; }
        public virtual ICollection<EavFormFieldset> EavFormFieldset { get; set; }
        public virtual ICollection<EavFormTypeEntity> EavFormTypeEntity { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
