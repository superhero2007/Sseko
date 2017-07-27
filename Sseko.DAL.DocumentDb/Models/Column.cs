using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Enums;

namespace Sseko.DAL.DocumentDb.Models
{
    public class Column
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
