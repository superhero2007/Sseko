namespace Sseko.Data.Models
{
    public partial class EavFormTypeEntity
    {
        public ushort TypeId { get; set; }
        public ushort EntityTypeId { get; set; }

        public virtual EavEntityType EntityType { get; set; }
        public virtual EavFormType Type { get; set; }
    }
}
