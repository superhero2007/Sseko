using System;
using System.Collections.Generic;
using System.Text;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.ReportGeneration.Messages
{
    public abstract class ReportGenerationOperations
    {
        public enum ReportType
        {
            PvTransactionSummary,
            DownlineSummary
        }
        public interface IOperation
        {
            
        }

        public class Operation : IOperation
        {
            public Operation(ReportType reportType, int fellowId = 0)
            {
                ReportType = reportType;
                FellowId = fellowId;
            }

            public ReportType ReportType { get; internal set; }

            public int FellowId { get; internal set; }
        }

        public class Result
        {
            public Result(Report output)
            {
                Output = output;
            }
            public Report Output { get; internal set; }
            public Exception Exception { get; internal set; }
            public bool IsError => Exception != null;
        }
    }
}
