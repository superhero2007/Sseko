using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class UltimateShipperMethod
    {
        public int EntityId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ErrorText { get; set; }
        public string HandlingAction { get; set; }
        public decimal? HandlingFee { get; set; }
        public string HandlingType { get; set; }
        public string MethodIdentifier { get; set; }
        public string MethodName { get; set; }
        public decimal MethodRate { get; set; }
        public string MethodType { get; set; }
        public short? ShowMethod { get; set; }
        public short? Status { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
