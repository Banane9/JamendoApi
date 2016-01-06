using JamendoApi.ApiEntities.SetUser;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JamendoApi
{
    /// <summary>
    /// Represents a client for the write methods of the Jamendo Api v3.0.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/write-methods
    /// </summary>
    public sealed class JamendoWriteApiClient
    {
        private const string baseUrl = "https://api.jamendo.com/v3.0/setuser";

        private static StringContent content = new StringContent(string.Empty);

        private readonly string clientId;
        private readonly Func<string> getAccessToken;

        private readonly HttpClient httpClient;
        private readonly JsonSerializer serializer;

        internal JamendoWriteApiClient(string clientId, HttpClient httpClient, JsonSerializer serializer, Func<string> getAccessToken)
        {
            this.clientId = clientId;
            this.httpClient = httpClient;
            this.serializer = serializer;
            this.getAccessToken = getAccessToken;
        }

        /// <summary>
        /// Makes the user dislike the specified track or revokes it.
        /// </summary>
        /// <param name="trackId">The Id of the track.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<EmptyResult[]>> SetDislike(uint trackId)
        {
            return await deserializeAsync(await postAsync($"/dislike?client_id={clientId}&access_token={getAccessToken()}&track_id={trackId}"));
        }

        /// <summary>
        /// Makes the user a fan of the specified artist or revokes it.
        /// </summary>
        /// <param name="artistId">The Id of the artist.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<EmptyResult[]>> SetFan(uint artistId)
        {
            return await deserializeAsync(await postAsync($"/fan?client_id={clientId}&access_token={getAccessToken()}&artist_id={artistId}"));
        }

        /// <summary>
        /// Sets the specified track as a favorite of the user or revokes it.
        /// </summary>
        /// <param name="trackId">The Id of the track.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<EmptyResult[]>> SetFavorite(uint trackId)
        {
            return await deserializeAsync(await postAsync($"/favorite?client_id={clientId}&access_token={getAccessToken()}&track_id={trackId}"));
        }

        /// <summary>
        /// Makes the user like the specified track or revokes it.
        /// </summary>
        /// <param name="trackId">The Id of the track.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<EmptyResult[]>> SetLike(uint trackId)
        {
            return await deserializeAsync(await postAsync($"/like?client_id={clientId}&access_token={getAccessToken()}&track_id={trackId}"));
        }

        /// <summary>
        /// Adds the specified album to the user's My Album playlist (favorites) or revokes it.
        /// </summary>
        /// <param name="albumId">The Id of the album.</param>
        /// <returns>The deserialized response or null if the call wasn't successful.</returns>
        public async Task<JamendoApiResponse<EmptyResult[]>> SetMyAlbum(uint albumId)
        {
            return await deserializeAsync(await postAsync($"/myalbum?client_id={clientId}&access_token={getAccessToken()}&album_id={albumId}"));
        }

        private Task<JamendoApiResponse<EmptyResult[]>> deserializeAsync(Stream stream)
        {
            if (stream == null)
                return null;

            return Task.Run(() =>
                serializer.Deserialize<JamendoApiResponse<EmptyResult[]>>(new JsonTextReader(new StreamReader(stream))));
        }

        private async Task<Stream> postAsync(string suffixUrl)
        {
            var httpResponse = await httpClient.PostAsync(baseUrl + suffixUrl, content);

            if (!httpResponse.IsSuccessStatusCode)
                return null;

            return await httpResponse.Content.ReadAsStreamAsync();
        }
    }
}