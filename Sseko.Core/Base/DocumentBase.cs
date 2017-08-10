using System;
using Microsoft.Azure.Documents;
using Newtonsoft.Json;
using Sseko.Core.Enums;
using Sseko.Core.Interfaces;

namespace Sseko.Core.Base
{
    public abstract class DocumentBase : Resource, IDocument
    {
        protected DocumentBase(DocumentType documentType)
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
            DocumentType = documentType;
            PKey = documentType.ToString();
            Id = Guid.NewGuid().ToString();
        }

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