using JamendoApi.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace JamendoApi.ApiEntities.Users
{
    /// <summary>
    /// Represents the User object which is part of the /users/tracks results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/users/tracks
    /// </summary>
    [JsonObject]
    public sealed class TracksUser : BasicUser
    {
        /// <summary>
        /// Gets all tracks that the user has some kind of relation to.
        /// </summary>
        [JsonProperty(PropertyName = "tracks", Required = Required.Always)]
        public Track[] Tracks { get; private set; }

        /// <summary>
        /// Represents the track object which is part of the playlist result.
        /// </summary>
        [JsonObject]
        public sealed class Track
        {
            /// <summary>
            /// Gets the Id of the abum that the track is part of.
            /// Empty when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_id", Required = Required.Always)]
            public uint? AlbumId { get; private set; }

            /// <summary>
            /// Gets the url of a cover of the album that the track is part of in the size specified or a default one.
            /// Empty when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_image", Required = Required.Always)]
            public string AlbumImage { get; private set; }

            /// <summary>
            /// Gets the Id of the track's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
            public uint ArtistId { get; private set; }

            /// <summary>
            /// Gets the name (as opposed to display name) of the track's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_name", Required = Required.Always)]
            public string ArtistName { get; private set; }

            /// <summary>
            /// Gets the url of the track's audio in the specified audio format or 96kbps MP3 by default.
            /// </summary>
            [JsonProperty(PropertyName = "audio", Required = Required.Always)]
            public string Audio { get; private set; }

            /// <summary>
            /// Gets the url of the track's audio in the specified audio-dl format, the audio format or variable bit-rate MP3 by default.
            /// </summary>
            [JsonProperty(PropertyName = "audiodownload", Required = Required.Always)]
            public string AudioDownload { get; private set; }

            /// <summary>
            /// Gets the track's duration in seconds.
            /// </summary>
            [JsonProperty(PropertyName = "duration", Required = Required.Always)]
            public uint Duration { get; private set; }

            /// <summary>
            /// Gets the track's Id.
            /// </summary>
            [JsonProperty(PropertyName = "id", Required = Required.Always)]
            public uint Id { get; private set; }

            /// <summary>
            /// Gets the url of a track cover in the size specified or a default one.
            /// </summary>
            [JsonProperty(PropertyName = "image", Required = Required.Always)]
            public string Image { get; private set; }

            /// <summary>
            /// Gets whether the track is a single or not.
            /// </summary>
            [JsonIgnore]
            public bool IsSingle
            {
                get { return !AlbumId.HasValue; }
            }

            /// <summary>
            /// Gets the track's CreativeCommons license url.
            /// </summary>
            [JsonProperty(PropertyName = "license_ccurl", Required = Required.Always)]
            public string LicenseCCUrl { get; private set; }

            /// <summary>
            /// Gets the track's name.
            /// </summary>
            [JsonProperty(PropertyName = "name", Required = Required.Always)]
            public string Name { get; private set; }

            /// <summary>
            /// Gets the user's relations to the track.
            /// <para/>
            /// A value other than 0 designates that the relation is there.
            /// <para/>
            /// For Review, the value indicates the score given.
            /// </summary>
            public ReadOnlyDictionary<TrackRelation, uint> Relations { get; private set; }

            /// <summary>
            /// Gets the track's release date.
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
        }
    }
}