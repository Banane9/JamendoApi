using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Albums
{
    /// <summary>
    /// Represents the Album object which is part of the /albums/tracks results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/albums/tracks
    /// </summary>
    [JsonObject]
    public sealed class TracksAlbum : IJamendoApiEntity
    {
        /// <summary>
        /// Gets the artist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
        public uint ArtistId { get; private set; }

        /// <summary>
        /// Gets the artist's name.
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
        /// Gets the album's release date.
        /// </summary>
        [JsonProperty(PropertyName = "releasedate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ReleaseDate { get; private set; }

        /// <summary>
        /// Gets the album's tracks.
        /// </summary>
        [JsonProperty(PropertyName = "tracks", Required = Required.Always)]
        public Track[] Tracks { get; private set; }

        /// <summary>
        /// Gets the url of a zip containing the album's tracks as 198kbps MP3.
        /// </summary>
        [JsonProperty(PropertyName = "zip", Required = Required.Always)]
        public string Zip { get; private set; }

        /// <summary>
        /// Represents the Track object which is part of the album result.
        /// </summary>
        [JsonObject]
        public sealed class Track
        {
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
            /// Gets the track's position in the album.
            /// </summary>
            [JsonProperty(PropertyName = "position", Required = Required.Always)]
            public uint Position { get; set; }
        }
    }
}