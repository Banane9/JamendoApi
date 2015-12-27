using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Artists
{
    /// <summary>
    /// Represents the Artist object which is part of the /artists/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/artists
    /// </summary>
    [JsonObject]
    public class BasicArtist
    {
        /// <summary>
        /// Gets the artist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the url of the artist's profile image.
        /// </summary>
        [JsonProperty(PropertyName = "image", Required = Required.Always)]
        public string Image { get; private set; }

        /// <summary>
        /// Gets the artist's join date.
        /// </summary>
        [JsonProperty(PropertyName = "joindate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime JoinDate { get; private set; }

        /// <summary>
        /// Gets the artist's name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the artist's share url.
        /// </summary>
        [JsonProperty(PropertyName = "shareurl", Required = Required.Always)]
        public string ShareUrl { get; private set; }

        /// <summary>
        /// Gets the artist's short url.
        /// </summary>
        [JsonProperty(PropertyName = "shorturl", Required = Required.Always)]
        public string ShortUrl { get; private set; }

        /// <summary>
        /// Gets the url of the artist's website.
        /// </summary>
        [JsonProperty(PropertyName = "website", Required = Required.Always)]
        public string Website { get; private set; }
    }
}