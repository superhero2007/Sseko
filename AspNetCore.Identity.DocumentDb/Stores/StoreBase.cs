using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Options;
using System;

namespace AspNetCore.Identity.DocumentDb.Stores
{
    public abstract class StoreBase
    {
        protected bool Disposed = false;

        protected IDocumentClient DocumentClient;
        protected DocumentDbOptions Options;
        protected Uri CollectionUri;
        protected string CollectionName;

        protected StoreBase(IDocumentClient documentClient, IOptions<DocumentDbOptions> options, string collectionName)
        {
            this.DocumentClient = documentClient;
            this.Options = options.Value;
            this.CollectionName = collectionName;

            this.CollectionUri = UriFactory.CreateDocumentCollectionUri(this.Options.Database, collectionName);
        }

        protected virtual void ThrowIfDisposed()
        {
            if (Disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        protected Uri GenerateDocumentUri(string documentId)
        {
            return UriFactory.CreateDocumentUri(Options.Database, CollectionName, documentId);
        }
    }
}
