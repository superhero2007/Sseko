using Sseko.Data.Enums;
using System;

namespace Sseko.Data.Models
{
    public partial class GiftcardsCard
    {
        public byte CardStatus { get; set; }
        public CardType CardType { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? MailDeliveryDate { get; set; }
        public DateTime? UpdatedTime { get; set; }
        public decimal CardAmount { get; set; }
        public decimal CardBalance { get; set; }
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public string CardCode { get; set; }
        public string CardCurrency { get; set; }
        public string MailFrom { get; set; }
        public string MailMessage { get; set; }
        public string MailTo { get; set; }
        public string MailToEmail { get; set; }
        public string OfflineCity { get; set; }
        public string OfflineCountry { get; set; }
        public string OfflinePhone { get; set; }
        public string OfflineState { get; set; }
        public string OfflineStreet { get; set; }
        public string OfflineZip { get; set; }
    }
}