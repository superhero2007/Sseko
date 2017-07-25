using System;
using Microsoft.Azure.Documents;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Enums;

namespace Sseko.DAL.DocumentDb.Base
{
    public abstract class DocumentBase : Resource
    {
        protected DocumentBase(DocumentType documentType)
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
            DocumentType = documentType;
            PKey = documentType.ToString();

        }
        [JsonProperty(PropertyName = "id")]
        public override string Id { get; set; }

        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public DateTime Modified { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "documentType")]
        public DocumentType DocumentType { get; set; }

        [JsonProperty(PropertyName = "pKey")]
        public string PKey { get; set; }
    }
}