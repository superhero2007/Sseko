namespace Sseko.Data.Models
{
    public partial class CustomerEavAttribute
    {
        public ushort AttributeId { get; set; }
        public string DataModel { get; set; }
        public string InputFilter { get; set; }
        public ushort IsSystem { get; set; }
        public ushort IsVisible { get; set; }
        public ushort MultilineCount { get; set; }
        public int SortOrder { get; set; }
        public string ValidateRules { get; set; }

        public virtual EavAttribute Attribute { get; set; }
    }
}
