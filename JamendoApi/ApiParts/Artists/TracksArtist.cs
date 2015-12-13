using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Artists
{
    /// <summary>
    /// Represents the Artist object which is part of the /artists/tracks results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/artists/tracks
    /// </summary>
    [JsonObject]
    public sealed class TracksArtist : IJamendoApiEntity
    {
        /// <summary>
        /// Gets the artist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the url of the artist's profile image.
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
        /// Gets the artist's tracks.
        /// </summary>
        [JsonProperty(PropertyName = "tracks", Required = Required.Always)]
        public Track[] Tracks { get; private set; }

        /// <summary>
        /// Gets the url of the artist's website.
        /// </summary>
        [JsonProperty(PropertyName = "website", Required = Required.Always)]
        public string Website { get; private set; }

        /// <summary>
        /// Represents the Track object which is part of the artist result.
        /// </summary>
        [JsonObject]
        public sealed class Track
        {
            /// <summary>
            /// Gets the Id of the album that the track is part of. No value when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_id", Required = Required.AllowNull)]
            public uint? AlbumId { get; set; }

            /// <summary>
            /// Gets the url of a cover of the album that the track is part of in the size specified or a default one.
            /// Empty when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_image", Required = Required.Always)]
            public string AlbumImage { get; private set; }

            /// <summary>
            /// Gets the name of the album that the track is part of. Empty when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_name", Required = Required.Always)]
            public string AlbumName { get; private set; }

            /// <summary>
            /// Gets the url of the track's audio in the specified audio format or 96kbps MP3 by default.
            /// </summary>
            [JsonProperty(PropertyName = "audio", Required = Required.Always)]
            public string Audio { get; set; }

            /// <summary>
            /// Gets the url of the track's audio in the specified audio-dl format, the audio format or variable bit-rate MP3 by default.
            /// </summary>
            [JsonProperty(PropertyName = "audiodownload", Required = Required.Always)]
            public string AudioDownload { get; set; }

            /// <summary>
            /// Gets the track's duration in seconds.
            /// </summary>
            [JsonProperty(PropertyName = "duration", Required = Required.Always)]
            public uint Duration { get; set; }

            /// <summary>
            /// Gets the track's Id.
            /// </summary>
            [JsonProperty(PropertyName = "id", Required = Required.Always)]
            public uint Id { get; set; }

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
            public string LicenseCCUrl { get; set; }

            /// <summary>
            /// Gets the track's name.
            /// </summary>
            [JsonProperty(PropertyName = "name", Required = Required.Always)]
            public string Name { get; set; }

            /// <summary>
            /// Gets the track's release date.
            /// </summary>
            [JsonProperty(PropertyName = "releasedate", Required = Required.Always)]
            [JsonConverter(typeof(IsoDateTimeConverter))]
            public DateTime ReleaseDate { get; private set; }
        }
    }
}