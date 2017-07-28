using System;
using System.Collections.Generic;

namespace Sseko.Akka.ReportGeneration.Messages
{
    public abstract class ReportOperations
    {
        public enum ReportType
        {
            PvTransactionSummary,
            DownlineSummary
        }
        public interface IOperation
        {
            
        }

        public class ReportOperation : IOperation
        {
            public ReportOperation(ReportType reportType, int fellowId = 0)
            {
                ReportType = reportType;
                FellowId = fellowId;
            }

            public ReportType ReportType { get; internal set; }

            public int FellowId { get; internal set; }
        }

        public class Result<T> : Data.QueryModels.Result<T>
        {
            public Result(T output, Exception exception = null)
            {
                Output = output;
                Exception = exception;
            }

            public Result(Data.QueryModels.Result<T> input)
            {
                Output = input.Output;
                Exception = input.Exception;
            }
        }

        public class ResultList<T> : Data.QueryModels.ResultList<T>
        {
            public ResultList(List<T> output, Exception exception = null)
            {
                Output = output;
                Exception = exception;
            }

            public ResultList(Data.QueryModels.ResultList<T> input)
            {
                Output = input.Output;
                Exception = input.Exception;
            }
        }

        public class GetNewFellows : IOperation
        {
            public GetNewFellows(DateTime? lastUpdated = null)
            {
                LastUpdated = lastUpdated;
            }
            public DateTime? LastUpdated { get; }
        }
    }
}
