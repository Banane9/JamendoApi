using JamendoApi.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Autocomplete
{
    /// <summary>
    /// Represents the match collection object which is part of the /autocomplete/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/autocomplete
    /// </summary>
    [JsonDictionary]
    public sealed class Matches : Dictionary<AutocompleteEntity, Matches.Match[]>
    {
        /// <summary>
        /// Represents the match object that's part of the match collection.
        /// </summary>
        [JsonObject]
        public sealed class Match
        {
            /// <summary>
            /// Gets the match's completion suggestion. E.g. "zero-project" for "zero-p"
            /// </summary>
            [JsonProperty(PropertyName = "match", Required = Required.Always)]
            public string Completion { get; private set; }

            /// <summary>
            /// Gets the number of entities that match the completion.
            /// </summary>
            [JsonProperty(PropertyName = "count", Required = Required.Always)]
            public uint Count { get; private set; }
        }
    }
}