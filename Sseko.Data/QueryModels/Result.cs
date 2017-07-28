using System;
using System.Collections.Generic;
using System.Text;

namespace Sseko.Data.QueryModels
{
    public class Result<T> : QueryBase
    {
        public T Output { get; set; }
    }
}
