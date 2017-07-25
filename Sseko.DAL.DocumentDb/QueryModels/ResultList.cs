using System.Collections.Generic;

namespace Sseko.DAL.DocumentDb.QueryModels
{
    public class ResultList<T> : QueryBase
    {
        public List<T> Output { get; set; }
    }
}