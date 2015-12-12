using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Entities
{
    [JsonObject]
    public sealed class Headers
    {
        [JsonProperty(PropertyName = "code")]
        public StatusCode Code { get; private set; }

        [JsonProperty(PropertyName = "error_message")]
        public string ErrorMessage { get; private set; }

        [JsonProperty(PropertyName = "results_count")]
        public uint ResultCount { get; private set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ResponseStatus Status { get; private set; }

        [JsonProperty(PropertyName = "warnings")]
        public string Warnings { get; private set; }

        public enum ResponseStatus
        {
            Success,
            Failed
        }

        public enum StatusCode
        {
            Success,
            Exception,
            HttpMethod,
            RequiredParameter,
            InvalidClientId,
            RateLimitExceeded,
            MethodNotFound,
            NeededParameter,
            Format,
            EntryPoint,
            SuspendedApplication,
            AccessToken,
            InsufficientScope,
            InvalidUser,
            EmailAlreadyExists,
            DuplicateValue
        }
    }
}