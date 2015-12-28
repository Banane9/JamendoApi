using JamendoApi.ApiCalls;
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
    public sealed class JamendoApiClient
    {
        private const string baseUrl = "https://api.jamendo.com/v3.0";
        private const string format = "json";
        private readonly string clientId;

        private readonly HttpClient httpClient;
        private readonly JsonSerializer serializer = new JsonSerializer();

        /// <summary>
        /// Creates a new instance of the <see cref="JamendoApiClient"/> class with the given client Id.
        /// </summary>
        /// <param name="clientId">The client Id required for the API to work.</param>
        /// <remarks>
        /// If a "MissingMethodException is thrown here, regarding a set_AutomaticDecompression method,
        /// then you have to add the Microsoft.Net.Http NuGet Package to your project.
        /// </remarks>
        public JamendoApiClient(string clientId)
        {
            if (string.IsNullOrWhiteSpace(clientId))
                throw new ArgumentNullException(nameof(clientId), "Client Id can't be null or whitespace.");

            this.clientId = clientId;

            var clientHandler = new HttpClientHandler();
            if (clientHandler.SupportsAutomaticDecompression)
                clientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            httpClient = new HttpClient(clientHandler);

            httpClient.DefaultRequestHeaders.Add("Host", "api.jamendo.com");
            httpClient.DefaultRequestHeaders.Add("UserAgent", "CSharp JamendoApi");
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json; charset=UTF-8");
            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
        }

        /// <summary>
        /// Executes a call to the API with the given call information.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="callInfo">The information describing the call.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<TResult>> Call<TResult>(CallInformation<TResult> callInfo)
        {
            var httpResponse = await httpClient.GetAsync(baseUrl + callInfo.GetQueryString(clientId, format));

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return serializer.Deserialize<JamendoApiResponse<TResult>>(
                new JsonTextReader(new StreamReader(await httpResponse.Content.ReadAsStreamAsync())));
        }

        /// <summary>
        /// Gets a stream of the zip that contains the album specified by the Id.
        /// </summary>
        /// <param name="albumId">The album Id.</param>
        /// <returns>Stream of the zip of the album.</returns>
        public async Task<Stream> GetAlbumZip(uint albumId)
        {
            var httpResponse = await httpClient.GetAsync(baseUrl + "/albums/file?client_id=" + clientId + "&id=" + albumId);

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return await httpResponse.Content.ReadAsStreamAsync();
        }

        /// <summary>
        /// Gets a stream of the zip that contains the playlist specified by the Id.
        /// </summary>
        /// <param name="playlistId">The playlist Id.</param>
        /// <returns>Stream of the zip of the playlist.</returns>
        public async Task<Stream> GetPlaylistZip(uint playlistId)
        {
            var httpResponse = await httpClient.GetAsync(baseUrl + "/playlists/file?client_id=" + clientId + "&id=" + playlistId);

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return await httpResponse.Content.ReadAsStreamAsync();
        }

        /// <summary>
        /// Gets a stream of the mp3 of the track specified by the Id.
        /// </summary>
        /// <param name="trackId">The track Id.</param>
        /// <returns>Stream of the mp3 of the track.</returns>
        public async Task<Stream> GetTrackMp3(uint trackId)
        {
            var httpResponse = await httpClient.GetAsync(baseUrl + "/tracks/file?client_id=" + clientId + "&id=" + trackId);

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return await httpResponse.Content.ReadAsStreamAsync();
        }
    }
}