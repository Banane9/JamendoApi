using JamendoApi.ApiParts.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public MusicInfo MusicInfo { get; private set; }
    }
}