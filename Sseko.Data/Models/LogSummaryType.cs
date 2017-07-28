namespace Sseko.Data.Models
{
    public partial class LogSummaryType
    {
        public ushort TypeId { get; set; }
        public ushort Period { get; set; }
        public string PeriodType { get; set; }
        public string TypeCode { get; set; }
    }
}
