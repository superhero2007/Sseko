namespace Sseko.Data.Models
{
    public partial class EavFormElement
    {
        public int ElementId { get; set; }
        public ushort AttributeId { get; set; }
        public ushort? FieldsetId { get; set; }
        public int SortOrder { get; set; }
        public ushort TypeId { get; set; }

        public virtual EavAttribute Attribute { get; set; }
        public virtual EavFormFieldset Fieldset { get; set; }
        public virtual EavFormType Type { get; set; }
    }
}
