using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Users
{
    /// <summary>
    /// Represents the User object which is part of the /users/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/users
    /// </summary>
    [JsonObject]
    public class BasicUser
    {
        /// <summary>
        /// Gets the user's creation date.
        /// </summary>
        [JsonProperty(PropertyName = "creationdate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Gets the user's display name.
        /// </summary>
        [JsonProperty(PropertyName = "dispname", Required = Required.Always)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the user's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the url of a profile picture in the size specified or a default one.
        /// </summary>
        [JsonProperty(PropertyName = "image", Required = Required.Always)]
        public string Image { get; private set; }

        /// <summary>
        /// Gets the two letter language code of the user's language.
        /// </summary>
        [JsonProperty(PropertyName = "lang", Required = Required.Always)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets the user's name (as opposed to display name).
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }
    }
}