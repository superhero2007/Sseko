﻿using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Identity.DocumentDb;
using Newtonsoft.Json;
using Sseko.DAL.DocumentDb.Base;

namespace Sseko.DAL.DocumentDb.Entities
{
    public class Role : DocumentDbIdentityRole
    {
        protected Role()
        {
            Deleted = false;
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }

        [JsonProperty(PropertyName = "created")]
        public DateTime Created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public DateTime Modified { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }
    }
}