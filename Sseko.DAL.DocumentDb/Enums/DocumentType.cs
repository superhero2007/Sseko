using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sseko.DAL.DocumentDb.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DocumentType
    {
        User,
        Role,
        Report,
        ReportType
    }
}
