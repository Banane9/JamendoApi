using JamendoApi.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Tracks
{
    /// <summary>
    /// Represents the Track object which is part of the /tracks/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/tracks
    /// </summary>
    [JsonObject]
    public class BasicTrack
    {
        /// <summary>
        /// Gets the Id of the album that this track is part of.
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
        /// Gets the name of the abum that the track is part of.
        /// Empty when track is a single.
        /// </summary>
        [JsonProperty(PropertyName = "album_name", Required = Required.Always)]
        public string AlbumName { get; private set; }

        /// <summary>
        /// Gets the Id of the track's artist.
        /// </summary>
        [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
        public uint ArtistId { get; private set; }

        /// <summary>
        /// Gets the Id string of the track's artist.
        /// </summary>
        [JsonProperty(PropertyName = "artist_idstr", Required = Required.Always)]
        public string ArtistIdString { get; private set; }

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
        /// Gets whether the track's license info was included.
        /// </summary>
        [JsonIgnore]
        public bool HasLicenseInfo
        {
            get { return Licenses != null; }
        }

        /// <summary>
        /// Gets whether the track's lyrics were included.
        /// </summary>
        [JsonIgnore]
        public bool HasLyrics
        {
            get { return !string.IsNullOrWhiteSpace(Lyrics); }
        }

        /// <summary>
        /// Gets whether the track's music info was included.
        /// </summary>
        [JsonIgnore]
        public bool HasMusicInfo
        {
            get { return MusicInfo != null; }
        }

        /// <summary>
        /// Gets whether the track's stats info was included.
        /// </summary>
        [JsonIgnore]
        public bool HasStatsInfo
        {
            get { return Stats != null; }
        }

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
        /// Gets the track's license info.
        /// </summary>
        [JsonProperty(PropertyName = "licenses")]
        public Licensing Licenses { get; private set; }

        /// <summary>
        /// Gets the track's lyrics.
        /// </summary>
        [JsonProperty(PropertyName = "lyrics")]
        public string Lyrics { get; private set; }

        /// <summary>
        /// Gets the track's music info.
        /// </summary>
        [JsonProperty(PropertyName = "musicinfo")]
        public Musicinfo MusicInfo { get; private set; }

        /// <summary>
        /// Gets the track's name.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.Always)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the track's position ... somewhere.
        /// </summary>
        [JsonProperty(PropertyName = "position", Required = Required.Always)]
        public uint Position { get; private set; }

        /// <summary>
        /// Get's the track's pro-url.
        /// </summary>
        [JsonProperty(PropertyName = "prourl", Required = Required.Always)]
        public string ProUrl { get; private set; }

        /// <summary>
        /// Gets the track's release date.
        /// </summary>
        [JsonProperty(PropertyName = "releasedate", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ReleaseDate { get; private set; }

        /// <summary>
        /// Gets the track's share url.
        /// </summary>
        [JsonProperty(PropertyName = "shareurl", Required = Required.Always)]
        public string ShareUrl { get; private set; }

        /// <summary>
        /// Gets the track's short url.
        /// </summary>
        [JsonProperty(PropertyName = "shorturl", Required = Required.Always)]
        public string ShortUrl { get; private set; }

        /// <summary>
        /// Gets the track's stats info.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public StatsInfo Stats { get; private set; }

        /// <summary>
        /// Represents the licenses object which is part of the track result.
        /// <para/>
        /// Further information on the meaning of the licenses can be found here: http://creativecommons.org/licenses/
        /// </summary>
        [JsonObject]
        public class Licensing
        {
            /// <summary>
            /// Gets whether the CreativeCommons NoCommercial license applies to this track.
            /// </summary>
            [JsonProperty(PropertyName = "ccnc", Required = Required.Always)]
            public bool CCNC { get; private set; }

            /// <summary>
            /// Gets whether the CreativeCommons NoDerivative license applies to this track.
            /// </summary>
            [JsonProperty(PropertyName = "ccnd", Required = Required.Always)]
            public bool CCND { get; private set; }

            /// <summary>
            /// Gets whether the CreativeCommons ShareAlike license applies to this track.
            /// </summary>
            [JsonProperty(PropertyName = "ccsa", Required = Required.Always)]
            public bool CCSA { get; private set; }

            /// <summary>
            /// Gets whether the track is subscribed to jamendo's background-music commercial licensing program.
            /// <para/>
            /// More info about that here: https://pro.jamendo.com/music-for-public-spaces
            /// </summary>
            [JsonProperty(PropertyName = "probackground", Required = Required.Always)]
            public bool ProBackground { get; private set; }

            /// <summary>
            /// Gets whether the track is subscribed to jamendo's single-track commericla licensing program.
            /// <para/>
            /// More info about that here: https://pro.jamendo.com/royalty-free-music-library
            /// </summary>
            [JsonProperty(PropertyName = "prolicensing", Required = Required.Always)]
            public bool ProLicensing { get; private set; }
        }

        /// <summary>
        /// Represents the music info object which is part of the track result.
        /// </summary>
        [JsonObject]
        public sealed class Musicinfo
        {
            /// <summary>
            /// Gets whether the track is acoustic or electric.
            /// </summary>
            [JsonProperty(PropertyName = "acousticelectric", Required = Required.Always)]
            [JsonConverter(typeof(StringEnumConverter))]
            public AcousticElectric AcousticOrElectric { get; private set; }

            /// <summary>
            /// Gets what gender the track's voice represents.
            /// </summary>
            [JsonProperty(PropertyName = "gender", Required = Required.Always)]
            [JsonConverter(typeof(StringEnumConverter))]
            public Gender Gender { get; private set; }

            /// <summary>
            /// Gets the two letter language code of the track's language.
            /// May be empty if it's not set or if it doesn't have vocals.
            /// </summary>
            [JsonProperty(PropertyName = "lang", Required = Required.Always)]
            public string Language { get; private set; }

            /// <summary>
            /// Gets the track's tag info.
            /// </summary>
            [JsonProperty(PropertyName = "tags", Required = Required.Always)]
            public TagInfo Tags { get; private set; }

            /// <summary>
            /// Gets the track's tempo.
            /// </summary>
            [JsonProperty(PropertyName = "speed", Required = Required.Always)]
            [JsonConverter(typeof(StringEnumConverter))]
            public Tempo Tempo { get; private set; }

            /// <summary>
            /// Gets whether the track is vocal or instrumental.
            /// </summary>
            [JsonProperty(PropertyName = "vocalinstrumental", Required = Required.Always)]
            [JsonConverter(typeof(StringEnumConverter))]
            public VocalInstrumental VocalInstrumental { get; private set; }

            /// <summary>
            /// Represents the tag info object which is part of the music info object.
            /// </summary>
            [JsonObject]
            public sealed class TagInfo
            {
                /// <summary>
                /// Gets the track's genres.
                /// Tags are normalized to english.
                /// </summary>
                [JsonProperty(PropertyName = "genres", Required = Required.Always)]
                public string[] Genres { get; private set; }

                /// <summary>
                /// Gets the track's instruments.
                /// Tags are normalized to english.
                /// </summary>
                [JsonProperty(PropertyName = "instruments", Required = Required.Always)]
                public string[] Instruments { get; private set; }

                /// <summary>
                /// Gets various other tags.
                /// Tags are normalized to english.
                /// </summary>
                [JsonProperty(PropertyName = "vartags", Required = Required.Always)]
                public string[] Various { get; private set; }
            }
        }

        /// <summary>
        /// Represents the stats info object which is part of the track result.
        /// </summary>
        [JsonObject]
        public class StatsInfo
        {
            /// <summary>
            /// Gets the track's average rating.
            /// Between 0 and 10.
            /// </summary>
            [JsonProperty(PropertyName = "avgnote", Required = Required.Always)]
            public float AverageRating { get; private set; }

            /// <summary>
            /// Gets the track's numer of dislikes.
            /// </summary>
            [JsonProperty(PropertyName = "dislikes", Required = Required.Always)]
            public uint Dislikes { get; private set; }

            /// <summary>
            /// Gets the track's number of downloads.
            /// </summary>
            [JsonProperty(PropertyName = "rate_downloads_total", Required = Required.Always)]
            public uint Downloads { get; private set; }

            /// <summary>
            /// Gets the track's number of favorites.
            /// </summary>
            [JsonProperty(PropertyName = "favorited", Required = Required.Always)]
            public uint Favorites { get; private set; }

            /// <summary>
            /// Gets the track's number of likes.
            /// </summary>
            [JsonProperty(PropertyName = "likes", Required = Required.Always)]
            public uint Likes { get; private set; }

            /// <summary>
            /// Gets the track's number of listens.
            /// </summary>
            [JsonProperty(PropertyName = "rate_listened_total", Required = Required.Always)]
            public uint Listens { get; private set; }

            /// <summary>
            /// Gets the number of playlists that the track is part of.
            /// </summary>
            [JsonProperty(PropertyName = "playlisted", Required = Required.Always)]
            public uint Playlists { get; private set; }

            /// <summary>
            /// Gets the track's number of ratings.
            /// </summary>
            [JsonProperty(PropertyName = "notes", Required = Required.Always)]
            public uint Ratings { get; private set; }
        }
    }
}