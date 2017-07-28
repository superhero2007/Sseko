using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace AspNetCore.Identity.DocumentDb
{
    public static class Utilities
    {
        public static FeedOptions GetFeedOptions(string pKey)
        {
            return new FeedOptions
            {
                PartitionKey = new PartitionKey(pKey)
            };
        }

        public static RequestOptions GetRequestOptions(string pKey)
        {
            return new RequestOptions()
            {
                PartitionKey = new PartitionKey(pKey)
            };
        }
    }
}
