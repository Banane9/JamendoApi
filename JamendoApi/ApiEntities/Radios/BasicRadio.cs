using JamendoApi.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Radios
{
    /// <summary>
    /// Represents the Radio object which is part of the /radios/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/radios
    /// </summary>
    [JsonObject]
    public class BasicRadio
    {
        /// <summary>
        /// Gets the radio's display name.
        /// </summary>
        [JsonProperty(PropertyName = "dispname", Required = Required.Always)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the radio's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the url of a radio cover in the size specified or a default one.
        /// </summary>
        [JsonProperty(PropertyName = "image", Required = Required.Always)]
        public string Image { get; private set; }

        /// <summary>
        /// Gets the radio's unique name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the radio's type.
        /// <para/>
        /// Usually www. Pro requires special privileges to be accessed.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RadioType Type { get; private set; }
    }
}