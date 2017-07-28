namespace Sseko.Data.Models
{
    public partial class OnestepcheckoutSurvey
    {
        public int SurveyId { get; set; }
        public string Answer { get; set; }
        public int OrderId { get; set; }
        public string Question { get; set; }
    }
}
