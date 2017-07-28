namespace Sseko.Data.Models
{
    public partial class Api2AclUser
    {
        public int AdminId { get; set; }
        public int RoleId { get; set; }

        public virtual AdminUser Admin { get; set; }
        public virtual Api2AclRole Role { get; set; }
    }
}
