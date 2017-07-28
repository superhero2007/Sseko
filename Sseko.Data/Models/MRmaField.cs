namespace Sseko.Data.Models
{
    public partial class MRmaField
    {
        public int FieldId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsEditableCustomer { get; set; }
        public bool IsRequiredCustomer { get; set; }
        public bool IsRequiredStaff { get; set; }
        public bool IsShowInConfirmShipping { get; set; }
        public bool IsVisibleCustomer { get; set; }
        public string Name { get; set; }
        public short SortOrder { get; set; }
        public string Type { get; set; }
        public string Values { get; set; }
        public string VisibleCustomerStatus { get; set; }
    }
}
