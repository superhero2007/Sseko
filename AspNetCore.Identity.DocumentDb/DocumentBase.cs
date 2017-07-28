using Newtonsoft.Json;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentBase
    {
        [JsonProperty(PropertyName = "documentType")]
        public string DocumentType { get; set; }
    }
}
