namespace Sseko.Data.Models
{
    public partial class EavFormFieldsetLabel
    {
        public ushort FieldsetId { get; set; }
        public ushort StoreId { get; set; }
        public string Label { get; set; }

        public virtual EavFormFieldset Fieldset { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
