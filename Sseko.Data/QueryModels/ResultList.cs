using System;
using System.Collections.Generic;
using System.Text;

namespace Sseko.Data.QueryModels
{
    public class ResultList<T> : QueryBase
    {
        public List<T> Output { get; set; }
    }
}
