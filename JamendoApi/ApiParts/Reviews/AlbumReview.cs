using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Reviews
{
    /// <summary>
    /// Represents the Review object which is part of the /reviews/albums results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/reviews/albums
    /// </summary>
    [JsonObject]
    public sealed class AlbumReview
    {
        /// <summary>
        /// Gets the number of users that agree with this review.
        /// </summary>
        [JsonProperty(PropertyName = "agreecnt", Required = Required.Always)]
        public uint AgreeCount { get; private set; }

        /// <summary>
        /// Gets the Id of the album that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "album_id", Required = Required.Always)]
        public uint AlbumId { get; private set; }

        /// <summary>
        /// Gets the name of the album that the review was made for.
        /// </summary>
        [JsonProperty(PropertyName = "album_name", Required = Required.Always)]
        public string AlbumName { get; private set; }

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