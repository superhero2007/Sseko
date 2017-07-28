using System.Collections.Generic;

namespace Sseko.Data.QueryModels
{
    public class ResultList<T> : QueryBase
    {
        public List<T> Output { get; set; }
    }
}
