using JamendoApi.ApiCalls;
using JamendoApi.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace JamendoApi
{
    /// <summary>
    /// Represents the client to query the Jamendo Api v3.0.
    /// </summary>
    public sealed class JamendoApiClient
    {
        private const string baseUrl = "https://api.jamendo.com/v3.0";

        private readonly string clientId;

        private readonly HttpClient httpClient;
        private readonly JsonSerializer serializer = new JsonSerializer();

        private readonly JamendoWriteApiClient writeMethods;

        /// <summary>
        /// Gets a client for the write methods of the Api if a function to get an access token was provided.
        /// </summary>
        public JamendoWriteApiClient WriteMethods
        {
            get
            {
                if (writeMethods == null)
                    throw new NotSupportedException("You have to provide a function to get an access token to enable write methods.");

                return writeMethods;
            }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="JamendoApiClient"/> class with the given client Id.
        /// </summary>
        /// <param name="clientId">The client Id required for the API to work.</param>
        /// <param name="getAccessToken">A function that lets the client get the OAuth access token required for write methods.</param>
        /// <remarks>
        /// If a "MissingMethodException is thrown here, regarding a set_AutomaticDecompression method,
        /// then you have to add the Microsoft.Net.Http NuGet Package to your project.
        /// </remarks>
        public JamendoApiClient(string clientId, Func<string> getAccessToken = null)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentNullException(nameof(clientId), "Client Id can't be null or whitespace.");

            this.clientId = clientId;

            var clientHandler = new HttpClientHandler();
            if (clientHandler.SupportsAutomaticDecompression)
                clientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            httpClient = new HttpClient(clientHandler);

            httpClient.DefaultRequestHeaders.Add("Host", "api.jamendo.com");
            httpClient.DefaultRequestHeaders.Add("UserAgent", "CSharp JamendoApi Client");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json; charset=UTF-8");
            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");

            if (getAccessToken == null)
                return;

            writeMethods = new JamendoWriteApiClient(clientId, httpClient, serializer, getAccessToken);
        }

        /// <summary>
        /// Executes a call to the API with the given call information.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="callInfo">The information describing the call.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<TResult>> CallAsync<TResult>(CallInformation<TResult> callInfo)
        {
            return await deserializeAsync<TResult>(await getAsync(callInfo.GetQueryString(clientId)));
        }

        /// <summary>
        /// Gets a stream of the specified file type specified by the Id.
        /// </summary>
        /// <param name="id">The Id of the file.</param>
        /// <returns>Stream of the file.</returns>
        public async Task<Stream> GetFileAsync(ApiFile file, uint id)
        {
            return await getAsync($"/{file.GetName()}/file?client_id={clientId}&id={id}");
        }

        private Task<JamendoApiResponse<TResult>> deserializeAsync<TResult>(Stream stream)
        {
            if (stream == null)
                return null;

            return Task.Run(() =>
                serializer.Deserialize<JamendoApiResponse<TResult>>(new JsonTextReader(new StreamReader(stream))));
        }

        private async Task<Stream> getAsync(string suffixUrl)
        {
            var httpResponse = await httpClient.GetAsync(baseUrl + suffixUrl);

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return await httpResponse.Content.ReadAsStreamAsync();
        }
    }
}