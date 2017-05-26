using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class PaypalSettlementReport
    {
        public PaypalSettlementReport()
        {
            PaypalSettlementReportRow = new HashSet<PaypalSettlementReportRow>();
        }

        public int ReportId { get; set; }
        public string AccountId { get; set; }
        public string Filename { get; set; }
        public DateTime? LastModified { get; set; }
        public DateTime? ReportDate { get; set; }

        public virtual ICollection<PaypalSettlementReportRow> PaypalSettlementReportRow { get; set; }
    }
}
