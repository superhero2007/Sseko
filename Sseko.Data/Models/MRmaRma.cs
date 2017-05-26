using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class MRmaRma
    {
        public MRmaRma()
        {
            MRmaComment = new HashSet<MRmaComment>();
            MRmaFedexLabel = new HashSet<MRmaFedexLabel>();
            MRmaItem = new HashSet<MRmaItem>();
            MRmaOfflineItem = new HashSet<MRmaOfflineItem>();
            MRmaRmaCreditmemo = new HashSet<MRmaRmaCreditmemo>();
            MRmaRmaOrder = new HashSet<MRmaRmaOrder>();
            MRmaRmaStore = new HashSet<MRmaRmaStore>();
        }

        public int RmaId { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreditMemoId { get; set; }
        public int? CustomerId { get; set; }
        public string Email { get; set; }
        public int? ExchangeOrderId { get; set; }
        public string Firstname { get; set; }
        public string GuestId { get; set; }
        public string IncrementId { get; set; }
        public bool IsAdminRead { get; set; }
        public bool IsArchived { get; set; }
        public bool IsGift { get; set; }
        public bool IsResolved { get; set; }
        public DateTime? LastReplyAt { get; set; }
        public string LastReplyName { get; set; }
        public string Lastname { get; set; }
        public string OfflineAddress { get; set; }
        public int OrderId { get; set; }
        public string Postcode { get; set; }
        public string Region { get; set; }
        public int? RegionId { get; set; }
        public int StatusId { get; set; }
        public ushort StoreId { get; set; }
        public string Street { get; set; }
        public string Telephone { get; set; }
        public int? TicketId { get; set; }
        public string TrackingCode { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<MRmaComment> MRmaComment { get; set; }
        public virtual ICollection<MRmaFedexLabel> MRmaFedexLabel { get; set; }
        public virtual ICollection<MRmaItem> MRmaItem { get; set; }
        public virtual ICollection<MRmaOfflineItem> MRmaOfflineItem { get; set; }
        public virtual ICollection<MRmaRmaCreditmemo> MRmaRmaCreditmemo { get; set; }
        public virtual ICollection<MRmaRmaOrder> MRmaRmaOrder { get; set; }
        public virtual ICollection<MRmaRmaStore> MRmaRmaStore { get; set; }
        public virtual CustomerEntity Customer { get; set; }
        public virtual MRmaStatus Status { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
