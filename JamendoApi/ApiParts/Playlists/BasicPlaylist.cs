using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Playlists
{
    /// <summary>
    /// Represents the Playlist object which is part of the /playlists/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/playlists
    /// </summary>
    [JsonObject]
    public sealed class BasicPlaylist
    {
        /// <summary>
        /// Gets the playlist's creation date.
        /// </summary>
        [JsonProperty(PropertyName = "creationdate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Gets the playlist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the playlist's name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the playlist's share url.
        /// </summary>
        [JsonProperty(PropertyName = "shareurl", Required = Required.Always)]
        public string ShareUrl { get; private set; }

        /// <summary>
        /// Gets the playlist's short url.
        /// </summary>
        [JsonProperty(PropertyName = "shorturl", Required = Required.Always)]
        public string ShortUrl { get; private set; }

        /// <summary>
        /// Gets the Id of the user that created the playlist.
        /// </summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public uint UserId { get; private set; }

        /// <summary>
        /// Gets the name (as opposed to display name) of the user that created the playlist.
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.Always)]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the url of a zip containing the playlists's tracks as 198kbps MP3.
        /// <para/>
        /// The zip may not contain all songs of the playlist, as there's a server-side limit of 100.
        /// </summary>
        [JsonProperty(PropertyName = "zip", Required = Required.Always)]
        public string Zip { get; private set; }
    }
}