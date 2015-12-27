using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiEntities.Reviews
{
    /// <summary>
    /// Represents the Review object which is part of the /reviews/tracks results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/reviews/tracks
    /// </summary>
    [JsonObject]
    public class TrackReview
    {
        /// <summary>
        /// Gets the number of users that agree with this review.
        /// </summary>
        [JsonProperty(PropertyName = "agreecnt", Required = Required.Always)]
        public uint AgreeCount { get; private set; }

        /// <summary>
        /// Gets the Id of the album that the track which the review was made for is a part of.
        /// </summary>
        [JsonProperty(PropertyName = "album_id", Required = Required.Always)]
        public uint AlbumId { get; private set; }

        /// <summary>
        /// Gets the Id of the artist that posted the album that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "artist_id", Required = Required.Always)]
        public uint ArtistId { get; private set; }

        /// <summary>
        /// Gets the date at which the review was posted.
        /// </summary>
        [JsonProperty(PropertyName = "dateadded", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime DateAdded { get; private set; }

        /// <summary>
        /// Gets whether this review has a score rating or not.
        /// </summary>
        [JsonIgnore]
        public bool HasScore
        {
            get { return Score.HasValue; }
        }

        /// <summary>
        /// Gets the review's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the review's two letter language code.
        /// </summary>
        [JsonProperty(PropertyName = "lang", Required = Required.Always)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets the review's score rating. May not always be present.
        /// </summary>
        [JsonProperty(PropertyName = "score", Required = Required.AllowNull)]
        public uint? Score { get; private set; }

        /// <summary>
        /// Gets the review's text.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public string Text { get; private set; }

        /// <summary>
        /// Gets the review's title.
        /// </summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public string Title { get; private set; }

        /// <summary>
        /// Gets the url of the track's audio in the specified audio format or 96kbps MP3 by default.
        /// </summary>
        [JsonProperty(PropertyName = "track_audio", Required = Required.Always)]
        public string TrackAudio { get; private set; }

        /// <summary>
        /// Gets the url of the track's audio in the specified audio-dl format, the audio format or variable bit-rate MP3 by default.
        /// </summary>
        [JsonProperty(PropertyName = "track_audiodownload", Required = Required.Always)]
        public string TrackAudioDownload { get; private set; }

        /// <summary>
        /// Gets the Id of the track that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "track_id", Required = Required.Always)]
        public uint TrackId { get; private set; }

        /// <summary>
        /// Gets the CreativeCommons license url of the track that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "track_license_ccurl", Required = Required.Always)]
        public string TrackLicenseCCUrl { get; private set; }

        /// <summary>
        /// Gets the name of the track that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "track_name", Required = Required.Always)]
        public string TrackName { get; private set; }

        /// <summary>
        /// Gets the display name of the review's author.
        /// </summary>
        [JsonProperty(PropertyName = "user_displayname", Required = Required.Always)]
        public string UserDisplayName { get; private set; }

        /// <summary>
        /// Gets the Id of the review's author.
        /// </summary>
        [JsonProperty(PropertyName = "user_id", Required = Required.Always)]
        public uint UserId { get; private set; }

        /// <summary>
        /// Gets the name of the review's author.
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.Always)]
        public string UserName { get; private set; }
    }
}