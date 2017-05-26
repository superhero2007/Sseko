using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class Giftvoucher
    {
        public Giftvoucher()
        {
            GiftvoucherCustomerVoucher = new HashSet<GiftvoucherCustomerVoucher>();
            GiftvoucherHistory = new HashSet<GiftvoucherHistory>();
        }

        public int GiftvoucherId { get; set; }
        public string ActionsSerialized { get; set; }
        public decimal? Balance { get; set; }
        public string ConditionsSerialized { get; set; }
        public string CreatedForm { get; set; }
        public string Currency { get; set; }
        public string CustomerEmail { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DayStore { get; set; }
        public DateTime? DayToSend { get; set; }
        public string Description { get; set; }
        public bool? EmailSender { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public string GiftCode { get; set; }
        public bool? GiftcardCustomImage { get; set; }
        public int? GiftcardTemplateId { get; set; }
        public string GiftcardTemplateImage { get; set; }
        public string GiftvoucherComments { get; set; }
        public bool? IsSent { get; set; }
        public string Message { get; set; }
        public bool? NotifySuccess { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public bool ShippedToCustomer { get; set; }
        public short Status { get; set; }
        public ushort StoreId { get; set; }
        public int? TemplateId { get; set; }
        public string TimezoneToSend { get; set; }

        public virtual ICollection<GiftvoucherCustomerVoucher> GiftvoucherCustomerVoucher { get; set; }
        public virtual ICollection<GiftvoucherHistory> GiftvoucherHistory { get; set; }
        public virtual GiftcardTemplate GiftcardTemplate { get; set; }
    }
}
