using System;

namespace Sseko.Data.Models
{
    public partial class GiftcardsLog
    {
        public int EntityId { get; set; }
        public string CardAction { get; set; }
        public decimal CardAmount { get; set; }
        public decimal CardBalance { get; set; }
        public string CardCode { get; set; }
        public string CardComment { get; set; }
        public int CardId { get; set; }
        public byte CardStatus { get; set; }
        public DateTime CreatedTime { get; set; }
        public string OrderId { get; set; }
        public string User { get; set; }
        public string UserName { get; set; }
    }
}
