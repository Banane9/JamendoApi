using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JamendoApi.ApiEntities.Users
{
    /// <summary>
    /// Represents the User object which is part of the /users/artists results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/users/artists
    /// </summary>
    [JsonObject]
    public sealed class ArtistsUser : BasicUser
    {
        /// <summary>
        /// Gets all artists that the user has some kind of relation to.
        /// </summary>
        [JsonProperty(PropertyName = "artists", Required = Required.Always)]
        public Artist[] Artists { get; private set; }

        /// <summary>
        /// Represents the artist object which is part of the user result.
        /// </summary>
        [JsonObject]
        public sealed class Artist
        {
            /// <summary>
            /// Gets the artist's Id.
            /// </summary>
            [JsonProperty(PropertyName = "id", Required = Required.Always)]
            public uint Id { get; private set; }

            /// <summary>
            /// Gets the url of a profile picture in the size specified or a default one.
            /// </summary>
            [JsonProperty(PropertyName = "image", Required = Required.Always)]
            public string Image { get; private set; }

            /// <summary>
            /// Gets the artist's join date.
            /// </summary>
            [JsonProperty(PropertyName = "joindate", Required = Required.Always)]
            [JsonConverter(typeof(IsoDateTimeConverter))]
            public DateTime JoinDate { get; private set; }

            /// <summary>
            /// Gets the artist's name.
            /// </summary>
            [JsonProperty(PropertyName = "name", Required = Required.Always)]
            public string Name { get; private set; }

            /// <summary>
            /// Gets the user's relations to the artist.
            /// <para/>
            /// A value other than 0 designates that the relation is there.
            /// </summary>
            [JsonProperty(PropertyName = "relations", Required = Required.Always)]
            public ReadOnlyDictionary<Relation, uint> Relations { get; private set; }

            /// <summary>
            /// Gets the date of the last change in relations.
            /// </summary>
            [JsonProperty(PropertyName = "updatedate", Required = Required.Always)]
            [JsonConverter(typeof(IsoDateTimeConverter))]
            public DateTime UpdateDate { get; private set; }

            /// <summary>
            /// Lists the possible values for the type of relation.
            /// </summary>
            public enum Relation
            {
                /// <summary>
                /// The user is a fan of the artist.
                /// </summary>
                Fan
            }
        }
    }
}