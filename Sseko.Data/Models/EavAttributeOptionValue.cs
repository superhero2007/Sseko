namespace Sseko.Data.Models
{
    public partial class EavAttributeOptionValue
    {
        public int ValueId { get; set; }
        public int OptionId { get; set; }
        public ushort StoreId { get; set; }
        public string Value { get; set; }

        public virtual EavAttributeOption Option { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
