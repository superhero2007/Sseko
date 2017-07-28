﻿namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentDbOptions
    {
        /// <summary>
        /// Gets or sets the name of the Database that should be used in DocumentDb.
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Gets or sets the name of the DocumentCollection that should be used to store and query users in DocumentDb.
        /// </summary>
        public string UserStoreDocumentCollection { get; set; }

        /// <summary>
        /// Gets or sets the name of the DocumentCollection that should be used to store and query roles in DocumentDb.
        /// </summary>
        public string RoleStoreDocumentCollection { get; set; }
    }
}
