using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Sseko.Core.Interfaces
{
    public interface IDocument
    {
        [JsonProperty(PropertyName = "id")]
        string Id { get; set; }
    }
}
