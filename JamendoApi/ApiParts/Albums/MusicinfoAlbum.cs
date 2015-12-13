using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JamendoApi.ApiParts.Albums
{
    /// <summary>
    /// Represents the Album object which is part of the /albums/musicinfo results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/albums/musicinfo
    /// </summary>
    [JsonObject]
    public class MusicInfoAlbum : BasicAlbum
    {
        /// <summary>
        /// Gets the album's music info.
        /// </summary>
        [JsonProperty(PropertyName = "musicinfo", Required = Required.Always)]
        public Musicinfo MusicInfo { get; private set; }

        /// <summary>
        /// Represents the musicinfo object that's part of the album result.
        /// </summary>
        [JsonObject]
        public sealed class Musicinfo
        {
            /// <summary>
            /// Gets the different descriptions of the album ordered by their two-letter language code.
            /// </summary>
            [JsonProperty(PropertyName = "description")]
            public ReadOnlyDictionary<string, string> Descriptions { get; private set; }

            /// <summary>
            /// Gets the album's tags (english based).
            /// </summary>
            [JsonProperty(PropertyName = "tags", Required = Required.Always)]
            public string[] Tags { get; private set; }
        }
    }
}