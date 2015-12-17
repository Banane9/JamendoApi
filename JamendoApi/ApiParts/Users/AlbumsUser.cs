using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JamendoApi.ApiParts.Users
{
    /// <summary>
    /// Represents the User object which is part of the /users/albums results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/users/albums
    /// </summary>
    [JsonObject]
    public sealed class AlbumsUser : BasicUser
    {
        /// <summary>
        /// Gets all albums that the user has some kind of relation to.
        /// </summary>
        [JsonProperty(PropertyName = "albums", Required = Required.Always)]
        public Album[] Albums { get; private set; }

        /// <summary>
        /// Represents the album object which is part of the user result.
        /// </summary>
        [JsonObject]
        public sealed class Album
        {
            /// <summary>
            /// Gets the Id of the album's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
            public uint ArtistId { get; private set; }

            /// <summary>
            /// Gets the name (as opposed to display name) of the album's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_name", Required = Required.Always)]
            public string ArtistName { get; private set; }

            /// <summary>
            /// Gets the album's Id.
            /// </summary>
            [JsonProperty(PropertyName = "id", Required = Required.Always)]
            public uint Id { get; private set; }

            /// <summary>
            /// Gets the url of an album cover in the size specified or a default one.
            /// </summary>
            [JsonProperty(PropertyName = "image", Required = Required.Always)]
            public string Image { get; private set; }

            /// <summary>
            /// Gets the album's name.
            /// </summary>
            [JsonProperty(PropertyName = "name", Required = Required.Always)]
            public string Name { get; private set; }

            /// <summary>
            /// Gets the user's relations to the album.
            /// <para/>
            /// A value other than 0 designates that the relation is there.
            /// </summary>
            [JsonProperty(PropertyName = "relations", Required = Required.Always)]
            public ReadOnlyDictionary<Relation, uint> Relations { get; private set; }

            /// <summary>
            /// Gets the album's release date.
            /// </summary>
            [JsonProperty(PropertyName = "releasedate", Required = Required.Always)]
            [JsonConverter(typeof(IsoDateTimeConverter))]
            public DateTime ReleaseDate { get; private set; }

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
                /// The user has added the album to his My Albums list.
                /// </summary>
                MyAlbum
            }
        }
    }
}