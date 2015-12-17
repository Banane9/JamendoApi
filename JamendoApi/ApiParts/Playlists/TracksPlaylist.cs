using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Playlists
{
    /// <summary>
    /// Represents the Playlist object which is part of the /playlists/tracks results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/playlists/tracks
    /// </summary>
    [JsonObject]
    public sealed class TracksPlaylist
    {
        /// <summary>
        /// Gets the playlist's creation date.
        /// </summary>
        [JsonProperty(PropertyName = "creationdate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Gets the playlist's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the playlist's name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the playlist's tracks.
        /// </summary>
        [JsonProperty(PropertyName = "tracks", Required = Required.Always)]
        public Track[] Tracks { get; private set; }

        /// <summary>
        /// Gets the Id of the user that created the playlist.
        /// </summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public uint UserId { get; private set; }

        /// <summary>
        /// Gets the name (as opposed to display name) of the user that created the playlist.
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.Always)]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the url of a zip containing the playlists's tracks as 198kbps MP3.
        /// <para/>
        /// The zip may not contain all songs of the playlist, as there's a server-side limit of 100.
        /// </summary>
        [JsonProperty(PropertyName = "zip", Required = Required.Always)]
        public string Zip { get; private set; }

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
            /// Gets the date at which the track was added to the playlist.
            /// </summary>
            [JsonProperty(PropertyName = "playlistadddate", Required = Required.Always)]
            [JsonConverter(typeof(IsoDateTimeConverter))]
            public DateTime DateAdded { get; private set; }

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
            /// Gets the track's position in the playlist.
            /// </summary>
            [JsonProperty(PropertyName = "position", Required = Required.Always)]
            public uint Position { get; private set; }
        }
    }
}