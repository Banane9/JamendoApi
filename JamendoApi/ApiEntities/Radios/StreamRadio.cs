using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Radios
{
    /// <summary>
    /// Represents the Radio object which is part of the /radios/stream results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/radios/stream
    /// </summary>
    [JsonObject]
    public sealed class StreamRadio : BasicRadio
    {
        /// <summary>
        /// Gets the time in ms that the program should wait before requesting the next song.
        /// </summary>
        [JsonProperty(PropertyName = "callmeback", Required = Required.Always)]
        public uint CallMeBack { get; private set; }

        /// <summary>
        /// Gets some information about the track that's currently playing.
        /// </summary>
        [JsonProperty(PropertyName = "playingnow", Required = Required.Always)]
        public Track PlayingNow { get; private set; }

        /// <summary>
        /// Gets the url at which the radio's music is streamed.
        /// </summary>
        [JsonProperty(PropertyName = "stream", Required = Required.Always)]
        public string Stream { get; private set; }

        /// <summary>
        /// Represents the Track object which is part of the radio result.
        /// </summary>
        [JsonObject]
        public sealed class Track
        {
            /// <summary>
            /// Gets the Id of the album that the track is part of. No value when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_id", Required = Required.Always)]
            public uint? AlbumId { get; private set; }

            /// <summary>
            /// Gets the name of the album that the track is part of. Empty when track is a single.
            /// </summary>
            [JsonProperty(PropertyName = "album_name", Required = Required.Always)]
            public string AlbumName { get; private set; }

            /// <summary>
            /// Gets the Id of the track's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
            public uint ArtistId { get; private set; }

            /// <summary>
            /// Gets the name of the track's artist.
            /// </summary>
            [JsonProperty(PropertyName = "artist_name", Required = Required.Always)]
            public string ArtistName { get; private set; }

            /// <summary>
            /// Gets the track's Id.
            /// </summary>
            [JsonProperty(PropertyName = "track_id", Required = Required.Always)]
            public uint Id { get; private set; }

            /// <summary>
            /// Gets the url of a track cover in the size specified or a default one.
            /// </summary>
            [JsonProperty(PropertyName = "track_image", Required = Required.Always)]
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
            /// Gets the track's name.
            /// </summary>
            [JsonProperty(PropertyName = "track_name", Required = Required.Always)]
            public string Name { get; set; }
        }
    }
}