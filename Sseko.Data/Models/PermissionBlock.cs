namespace Sseko.Data.Models
{
    public partial class PermissionBlock
    {
        public int BlockId { get; set; }
        public string BlockName { get; set; }
        public bool IsAllowed { get; set; }
    }
}
