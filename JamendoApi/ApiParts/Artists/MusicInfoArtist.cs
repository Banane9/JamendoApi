using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Artists
{
    /// <summary>
    /// Represents the Artist object which is part of the /artists/musicinfo results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/artists/musicinfo
    /// </summary>
    [JsonObject]
    public sealed class MusicInfoArtist
    {
        /// <summary>
        /// Gets the album's music info.
        /// </summary>
        [JsonProperty(PropertyName = "musicinfo", Required = Required.Always)]
        public MusicInfo MusicInfo { get; private set; }
    }
}