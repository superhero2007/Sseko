namespace Sseko.Data.Models
{
    public partial class PermissionVariable
    {
        public int VariableId { get; set; }
        public string VariableName { get; set; }
        public bool IsAllowed { get; set; }
    }
}
