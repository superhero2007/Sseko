using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentBase
    {
        [JsonProperty(PropertyName = "documentType")]
        public string DocumentType { get; set; }
    }
}
