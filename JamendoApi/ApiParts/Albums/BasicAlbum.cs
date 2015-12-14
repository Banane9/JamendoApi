using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Albums
{
    /// <summary>
    /// Represents the Album object which is part of the /albums/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/albums
    /// </summary>
    [JsonObject]
    public class BasicAlbum
    {
        /// <summary>
        /// Gets the artist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
        public uint ArtistId { get; private set; }

        /// <summary>
        /// Gets the artist's name.
        /// </summary>
        [JsonProperty(PropertyName = "artist_name", Required = Required.Always)]
        public string ArtistName { get; private set; }

        /// <summary>
        /// Gets the album's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the url of an album cover in the size specified or a default one.
        /// </summary>
        [JsonProperty(PropertyName = "image", Required = Required.Always)]
        public string Image { get; private set; }

        /// <summary>
        /// Gets the album's name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the album's release date.
        /// </summary>
        [JsonProperty(PropertyName = "releasedate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ReleaseDate { get; private set; }

        /// <summary>
        /// Gets the album's share url.
        /// </summary>
        [JsonProperty(PropertyName = "shareurl", Required = Required.Always)]
        public string ShareUrl { get; private set; }

        /// <summary>
        /// Gets the album's short url.
        /// </summary>
        [JsonProperty(PropertyName = "shorturl", Required = Required.Always)]
        public string ShortUrl { get; private set; }

        /// <summary>
        /// Gets the url of a zip containing the album's tracks as 198kbps MP3.
        /// </summary>
        [JsonProperty(PropertyName = "zip", Required = Required.Always)]
        public string Zip { get; private set; }
    }
}