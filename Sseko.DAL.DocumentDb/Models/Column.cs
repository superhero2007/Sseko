using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sseko.DAL.DocumentDb.Models
{
    public class Column
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public Type Type { get; set; }

        [JsonProperty(PropertyName = "sqlName")]
        public string SqlName { get; set; }

        [JsonProperty(PropertyName = "columnKey")]
        public bool ColumnKey { get; set; }
    }
}
