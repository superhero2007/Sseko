using System;

namespace Sseko.Data.Models
{
    public partial class XtentoOrderexportProfile
    {
        public int ProfileId { get; set; }
        public string ConditionsSerialized { get; set; }
        public string CronjobCustomFrequency { get; set; }
        public int CronjobEnabled { get; set; }
        public string CronjobFrequency { get; set; }
        public string CustomerGroups { get; set; }
        public string DestinationIds { get; set; }
        public int Enabled { get; set; }
        public string Encoding { get; set; }
        public string Entity { get; set; }
        public string EventObservers { get; set; }
        public string ExportActionAddComment { get; set; }
        public int ExportActionCancelOrder { get; set; }
        public string ExportActionChangeStatus { get; set; }
        public int ExportActionInvoiceNotify { get; set; }
        public int ExportActionInvoiceOrder { get; set; }
        public int ExportActionShipNotify { get; set; }
        public int ExportActionShipOrder { get; set; }
        public int ExportEmptyFiles { get; set; }
        public string ExportFields { get; set; }
        public DateTime? ExportFilterDatefrom { get; set; }
        public DateTime? ExportFilterDateto { get; set; }
        public int? ExportFilterLastXDays { get; set; }
        public int ExportFilterNewOnly { get; set; }
        public int? ExportFilterOlderXMinutes { get; set; }
        public string ExportFilterProductType { get; set; }
        public string ExportFilterStatus { get; set; }
        public int ExportOneFilePerObject { get; set; }
        public string Filename { get; set; }
        public DateTime? LastExecution { get; set; }
        public DateTime? LastModification { get; set; }
        public int ManualExportEnabled { get; set; }
        public string Name { get; set; }
        public string OutputType { get; set; }
        public int SaveFilesLocalCopy { get; set; }
        public int SaveFilesManualExport { get; set; }
        public int StartDownloadManualExport { get; set; }
        public string StoreIds { get; set; }
        public string TestId { get; set; }
        public string XslTemplate { get; set; }
    }
}
