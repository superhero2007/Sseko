using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogsearchQuery
    {
        public CatalogsearchQuery()
        {
            CatalogsearchResult = new HashSet<CatalogsearchResult>();
        }

        public int QueryId { get; set; }
        public short DisplayInTerms { get; set; }
        public short? IsActive { get; set; }
        public short? IsProcessed { get; set; }
        public int NumResults { get; set; }
        public int Popularity { get; set; }
        public string QueryText { get; set; }
        public string Redirect { get; set; }
        public ushort StoreId { get; set; }
        public string SynonymFor { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<CatalogsearchResult> CatalogsearchResult { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
