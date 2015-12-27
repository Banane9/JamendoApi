using JamendoApi.ApiEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JamendoApi
{
    /// <summary>
    /// Represents a response from the Jamendo Api.
    /// </summary>
    /// <typeparam name="TResult">The type of entities in the results field.</typeparam>
    [JsonObject]
    public sealed class JamendoApiResponse<TResult>
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
        public TResult Results { get; private set; }

        public JamendoApiResponse()
        {
            if (!((typeof(TResult).IsArray && typeof(TResult).GetElementType().GetTypeInfo().GetCustomAttributes<JsonObjectAttribute>(true).Any())
                | typeof(TResult).GetTypeInfo().GetCustomAttributes<JsonDictionaryAttribute>(true).Any()))
                throw new ArgumentException(nameof(TResult), "Type of the results must have a JsonObject attribute.");
        }
    }
}