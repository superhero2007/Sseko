namespace Sseko.Data.Models
{
    public partial class GiftvoucherCredit
    {
        public int CreditId { get; set; }
        public decimal? Balance { get; set; }
        public string Currency { get; set; }
        public int CustomerId { get; set; }

        public virtual CustomerEntity Customer { get; set; }
    }
}
