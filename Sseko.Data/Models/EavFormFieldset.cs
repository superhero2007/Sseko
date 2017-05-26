using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class EavFormFieldset
    {
        public EavFormFieldset()
        {
            EavFormElement = new HashSet<EavFormElement>();
            EavFormFieldsetLabel = new HashSet<EavFormFieldsetLabel>();
        }

        public ushort FieldsetId { get; set; }
        public string Code { get; set; }
        public int SortOrder { get; set; }
        public ushort TypeId { get; set; }

        public virtual ICollection<EavFormElement> EavFormElement { get; set; }
        public virtual ICollection<EavFormFieldsetLabel> EavFormFieldsetLabel { get; set; }
        public virtual EavFormType Type { get; set; }
    }
}
