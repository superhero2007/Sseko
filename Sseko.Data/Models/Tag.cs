using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagProperties = new HashSet<TagProperties>();
            TagRelation = new HashSet<TagRelation>();
            TagSummary = new HashSet<TagSummary>();
        }

        public int TagId { get; set; }
        public int? FirstCustomerId { get; set; }
        public ushort? FirstStoreId { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }

        public virtual ICollection<TagProperties> TagProperties { get; set; }
        public virtual ICollection<TagRelation> TagRelation { get; set; }
        public virtual ICollection<TagSummary> TagSummary { get; set; }
        public virtual CustomerEntity FirstCustomer { get; set; }
        public virtual CoreStore FirstStore { get; set; }
    }
}
