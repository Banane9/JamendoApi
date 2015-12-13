using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Parts
{
    /// <summary>
    /// Represents the Headers object which is part of every API response.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/response-codes
    /// </summary>
    [JsonObject]
    public sealed class Headers
    {
        /// <summary>
        /// Gets the response's status code.
        /// </summary>
        [JsonProperty(PropertyName = "code", Required = Required.Always)]
        public StatusCode Code { get; private set; }

        /// <summary>
        /// Gets the response's error message.
        /// </summary>
        [JsonProperty(PropertyName = "error_message", Required = Required.Always)]
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the number of top level results in the response.
        /// </summary>
        [JsonProperty(PropertyName = "results_count", Required = Required.Always)]
        public uint ResultCount { get; private set; }

        /// <summary>
        /// Gets the response's status.
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ResponseStatus Status { get; private set; }

        /// <summary>
        /// Gets the response's warning messages.
        /// </summary>
        [JsonProperty(PropertyName = "warnings", Required = Required.Always)]
        public string Warnings { get; private set; }

        public enum ResponseStatus
        {
            /// <summary>
            /// Request completed successfully or with warning(s).
            /// </summary>
            Success,

            /// <summary>
            /// Request couldn't be completed. Check Code and ErrorMessage.
            /// </summary>
            Failed
        }

        public enum StatusCode
        {
            /// <summary>
            /// Success (or success with warning).
            /// </summary>
            Success,

            /// <summary>
            /// A generic not well identificated error occurred.
            /// </summary>
            Exception,

            /// <summary>
            /// The received http method is not supported for this method.
            /// </summary>
            HttpMethod,

            /// <summary>
            /// One of the received parameters has a value not respecting requirements such as type, range, format, etc.
            /// </summary>
            Type,

            /// <summary>
            /// A required parameter was not been received, or it was empty.
            /// </summary>
            RequiredParameter,

            /// <summary>
            /// The client Id received does not exists or cannot be validated.
            /// </summary>
            InvalidClientId,

            /// <summary>
            /// This requester app or the requester IP have exceeded the permitted rate limit.
            /// </summary>
            RateLimitExceeded,

            /// <summary>
            /// Jamendo Api rest-like reading methods are in the format api.jamendo.com/version/entity/subentity (subentity is optional). This exception is raised when entity and/or subentity methods don't exist.
            /// </summary>
            MethodNotFound,

            /// <summary>
            /// A parameter needed because of an imposed local condition was not received or/and has not the needed value.
            /// </summary>
            NeededParameter,

            /// <summary>
            /// This exception is raised when the api call requests an unkown output format.
            /// </summary>
            Format,

            /// <summary>
            /// The used IP and/or port is not recognized as valid entry point.
            /// </summary>
            EntryPoint,

            /// <summary>
            /// The client application has been suspended (illegal usage, ...).
            /// </summary>
            SuspendedApplication,

            /// <summary>
            /// Invalid Access Token.
            /// </summary>
            AccessToken,

            /// <summary>
            /// Insufficient scope. The request requires higher privileges than provided by the access token.
            /// </summary>
            InsufficientScope,

            /// <summary>
            /// Some parameters of User is not valid.
            /// </summary>
            InvalidUser,

            /// <summary>
            /// The email is already used by another user.
            /// </summary>
            EmailAlreadyExists,

            /// <summary>
            /// This error is raised when a client tries to write or update a value which already exists and cannot be duplicated.
            /// </summary>
            DuplicateValue
        }
    }
}