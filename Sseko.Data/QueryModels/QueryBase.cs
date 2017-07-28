using System;

namespace Sseko.Data.QueryModels
{
    public class QueryBase
    {
        public Exception Exception { get; set; }
        public bool IsError => Exception != null;
    }
}
