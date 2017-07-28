namespace Sseko.Data.Models
{
    public partial class MRmaRule
    {
        public int RuleId { get; set; }
        public string ConditionsSerialized { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public string Event { get; set; }
        public int? IsActive { get; set; }
        public bool IsArchived { get; set; }
        public short IsResolved { get; set; }
        public bool IsSendAttachment { get; set; }
        public bool IsSendCustomer { get; set; }
        public bool IsSendDepartment { get; set; }
        public bool IsSendOwner { get; set; }
        public bool IsStopProcessing { get; set; }
        public string Name { get; set; }
        public string OtherEmail { get; set; }
        public short SortOrder { get; set; }
        public int? StatusId { get; set; }
        public int? UserId { get; set; }

        public virtual MRmaStatus Status { get; set; }
        public virtual AdminUser User { get; set; }
    }
}
