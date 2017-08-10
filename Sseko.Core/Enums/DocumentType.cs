using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sseko.Core.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentType
    {
        User
    }
}
