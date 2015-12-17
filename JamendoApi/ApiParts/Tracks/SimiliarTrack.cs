using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Tracks
{
    /// <summary>
    /// Represents the Track object which is part of the /tracks/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/tracks
    /// </summary>
    [JsonObject]
    public sealed class SimiliarTrack : BasicTrack
    {
        /// <summary>
        /// Gets the track's similarity score.
        /// <para/>
        /// Value ranges from 0 to 1; 1 is best.
        /// </summary>
        [JsonProperty(PropertyName = "score", Required = Required.Always)]
        public float Score { get; private set; }
    }
}