using JamendoApi.ApiParts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi
{
    /// <summary>
    /// Represents a response from the Jamendo Api.
    /// </summary>
    /// <typeparam name="TResult">The type of entities in the results field.</typeparam>
    [JsonObject]
    public sealed class JamendoApiResponse<TResult> where TResult : IJamendoApiEntity
    {
        /// <summary>
        /// Gets the response's headers.
        /// </summary>
        [JsonProperty(PropertyName = "headers", Required = Required.Always)]
        public Headers Headers { get; private set; }

        /// <summary>
        /// Gets the response's results.
        /// </summary>
        [JsonProperty(PropertyName = "results", Required = Required.Always)]
        public TResult[] Results { get; private set; }
    }
}