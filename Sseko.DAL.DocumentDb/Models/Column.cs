using Newtonsoft.Json;

namespace Sseko.DAL.DocumentDb.Models
{
    public class Column
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
