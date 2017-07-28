using System;

namespace Sseko.Data.Models
{
    public partial class GiftcardOrder
    {
        public int IdFake { get; set; }
        public DateTime? CreatedTime { get; set; }
        public decimal Discounted { get; set; }
        public int IdGiftcard { get; set; }
        public int IdOrder { get; set; }
    }
}
