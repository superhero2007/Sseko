using System;
using System.Collections.Generic;
using System.Text;
using Sseko.DAL.DocumentDb.Entities;

namespace Sseko.Akka.ReportGeneration.Messages
{
    public abstract class ReportGenerationOperations
    {
        public interface IOperation
        {
            
        }

        public class Operation : IOperation
        {
            public Operation(ReportType reportType)
            {
                ReportType = reportType;
            }

            public ReportType ReportType { get; set; }
        }

        public class Result
        {
            public Result(List<List<string>> output, Exception exception = null)
            {
                Output = output;
                Exception = exception;
            }

            public List<List<string>> Output { get; set; }
            public Exception Exception { get; set; }
            public bool IsError => Exception != null;
        }
    }
}
