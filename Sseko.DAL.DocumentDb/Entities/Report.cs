using System.Collections.Generic;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Base;
using Sseko.DAL.DocumentDb.Enums;
using Sseko.DAL.DocumentDb.Models;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class Report : DocumentBase
    {
        public Report() : base(DocumentType.Report)
        {
            
        }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "columns")]
        public List<Column> Columns { get; set; } = new List<Column>();

        [JsonProperty(PropertyName = "rows")]
        public List<List<string>> Rows { get; set; } = new List<List<string>>();
    }
}
