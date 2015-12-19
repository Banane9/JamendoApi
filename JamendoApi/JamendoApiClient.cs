using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace JamendoApi
{
    public sealed class JamendoApiClient
    {
        public const uint MaxLimit = 200;
        public const uint MinLimit = 1;
        private const string baseUrl = "https://api.jamendo.com/v3.0/";
        private readonly string clientId;

        private readonly HttpClient httpClient;

        public JamendoApiClient(string clientId)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentNullException(nameof(clientId), "Client Id can't be null or whitespace.");

            this.clientId = clientId;

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(baseUrl);
        }
    }
}