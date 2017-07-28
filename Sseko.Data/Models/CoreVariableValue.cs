namespace Sseko.Data.Models
{
    public partial class CoreVariableValue
    {
        public int ValueId { get; set; }
        public string HtmlValue { get; set; }
        public string PlainValue { get; set; }
        public ushort StoreId { get; set; }
        public int VariableId { get; set; }

        public virtual CoreStore Store { get; set; }
        public virtual CoreVariable Variable { get; set; }
    }
}
