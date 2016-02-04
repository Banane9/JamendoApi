using JamendoApi.ApiEntities;
using JamendoApi.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace JamendoApi
{
    /// <summary>
    /// Represents a response from the Jamendo Api.
    /// </summary>
    /// <typeparam name="TResult">The type of entities in the results field.</typeparam>
    [JsonObject]
    public sealed class JamendoApiResponse<TResult>
    {
        private static readonly ArrayOrObjectConverter<TResult> converter = new ArrayOrObjectConverter<TResult>();

        /// <summary>
        /// Have to use JsonExtensionData + OnDeserialized because using TResult als type parameter
        /// for the ArrayOrObjectConverter for the JsonConverter attribute isn't possible.
        /// </summary>
        [JsonExtensionData]
        private Dictionary<string, JToken> additionalData = null;

        /// <summary>
        /// Gets the response's headers.
        /// </summary>
        [JsonProperty(PropertyName = "headers", Required = Required.Always)]
        public Headers Headers { get; private set; }

        /// <summary>
        /// Gets the response's results.
        /// </summary>
        [JsonIgnore]
        public TResult Results { get; private set; }

        public JamendoApiResponse()
        {
            if (!((typeof(TResult).IsArray && typeof(TResult).GetElementType().GetTypeInfo().GetCustomAttributes<JsonObjectAttribute>(true).Any())
                | typeof(TResult).GetTypeInfo().GetCustomAttributes<JsonDictionaryAttribute>(true).Any()))
                throw new ArgumentException(nameof(TResult), "Type of the results must have a JsonObject attribute.");
        }

        [OnDeserialized]
        private void onDeserialized(StreamingContext _)
        {
            if (!additionalData.ContainsKey("results"))
                throw new FormatException("Json didn't contain the required \"results\" field.");

            // For the edge case of the autocomplete method returning an empty array instead of
            // the usual object when no matches are found.
            Results = converter.GetObject(additionalData["results"]);
        }
    }
}