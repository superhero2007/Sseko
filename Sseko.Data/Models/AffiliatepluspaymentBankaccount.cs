namespace Sseko.Data.Models
{
    public partial class AffiliatepluspaymentBankaccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string RoutingCode { get; set; }
        public string SwiftCode { get; set; }

        public virtual AffiliateplusAccount Account { get; set; }
    }
}
