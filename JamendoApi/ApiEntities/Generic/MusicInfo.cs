using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JamendoApi.ApiEntities.Generic
{
    /// <summary>
    /// Represents the musicinfo object that's part of the album and artist result.
    /// </summary>
    [JsonObject]
    public sealed class MusicInfo
    {
        /// <summary>
        /// Gets the different descriptions connected to their two-letter language code.
        /// The descriptions may contain HTML markup.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public ReadOnlyDictionary<string, string> Descriptions { get; private set; }

        /// <summary>
        /// Gets the tags (english based).
        /// </summary>
        [JsonProperty(PropertyName = "tags", Required = Required.Always)]
        public string[] Tags { get; private set; }
    }
}