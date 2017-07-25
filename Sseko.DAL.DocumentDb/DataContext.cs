using System;
using System.IO;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Sseko.DAL.DocumentDb
{
    public class DataContext
    {
        private string _authKey;
        private ConnectionPolicy _connectionPolicy;
        private string _endpointUri;

        public DataContext()
        {
            _authKey = "";
            _endpointUri = "";
            Database = "";
            CollectionName = "";

            Init();
        }

        public DataContext(string authKey, string endpointUri, string database, string collectionName, ConnectionPolicy connectionPolicy = null)
        {
            _authKey = authKey;
            _endpointUri = endpointUri;
            _connectionPolicy = connectionPolicy;
            Database = database;
            CollectionName = collectionName;

            Init();
        }

        private void Init()
        {
            if (_connectionPolicy == null)
            {
                var policy = new ConnectionPolicy
                {
                    ConnectionMode = ConnectionMode.Gateway,
                    EnableEndpointDiscovery = true,
                    RetryOptions = new RetryOptions { MaxRetryAttemptsOnThrottledRequests = 4, MaxRetryWaitTimeInSeconds = 2 },
                    RequestTimeout = TimeSpan.FromSeconds(3)
                };
            }

            if (string.IsNullOrWhiteSpace(_authKey)) throw new ArgumentException("Unable to load DocDBAuthKey from configuration file");
            if (string.IsNullOrWhiteSpace(_endpointUri)) throw new ArgumentException("Unable to load DocDBEndpointUri from configuration file");
            if (string.IsNullOrWhiteSpace(Database)) throw new ArgumentException("Unable to load DocDBDatabase from configuration file");
            if (string.IsNullOrWhiteSpace(CollectionName)) throw new ArgumentException("Unable to load DocDBCollectionName from configuration file");

            InitJsonConvert();
            InitClient();
        }

        private void InitJsonConvert()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.None,
                NullValueHandling = NullValueHandling.Include,
                DefaultValueHandling = DefaultValueHandling.Include,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
        }

        public ConnectionPolicy ConnectionPolicy
        {
            get => _connectionPolicy;
            set
            {
                _connectionPolicy = value;
                InitClient();
            }
        }

        public IDocumentClient Client { get; private set; }

        internal string CollectionName { get; }

        internal string Database { get; }

        private void InitClient()
        {
            if (!string.IsNullOrWhiteSpace(_authKey) && !string.IsNullOrWhiteSpace(_endpointUri))
                Client = new DocumentClient(new Uri(_endpointUri), _authKey, _connectionPolicy);
        }
    }
}