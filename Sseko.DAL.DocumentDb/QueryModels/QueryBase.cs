using System;

namespace Sseko.DAL.DocumentDb.QueryModels
{
    public class QueryBase
    {
        public string ContinuationToken { get; set; }
        public Exception Exception { get; set; }
        public bool IsError => Exception != null;
        public double? RequestCharge { get; set; }
    }
}