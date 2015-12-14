using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Feeds
{
    /// <summary>
    /// Represents the Feed object which is part of the /feeds/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/feeds
    /// </summary>
    [JsonObject]
    public sealed class BasicFeed : IJamendoApiEntity
    {
        /// <summary>
        /// Gets the languages that the feed was translated to (as two-letter codes).
        /// </summary>
        [JsonProperty(PropertyName = "lang", Required = Required.Always)]
        public string[] AvailableLanguages { get; private set; }

        /// <summary>
        /// Gets the date at which the feed will become inactive.
        /// </summary>
        [JsonProperty(PropertyName = "date_end", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// Gets the feed's Id.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public uint Id { get; private set; }

        /// <summary>
        /// Gets the different image options - different resolutions of the header image for the feed.
        /// </summary>
        [JsonProperty(PropertyName = "images", Required = Required.Always)]
        public ImageOptions Images { get; private set; }

        /// <summary>
        /// Gets the url of the feed's target entity.
        /// </summary>
        [JsonProperty(PropertyName = "link", Required = Required.Always)]
        public string Link { get; private set; }

        /// <summary>
        /// Gets the feed's position in the list.
        /// </summary>
        [JsonProperty(PropertyName = "position", Required = Required.Always)]
        public uint Position { get; private set; }

        /// <summary>
        /// Gets the date at which the feed became active.
        /// </summary>
        [JsonProperty(PropertyName = "date_start", Required = Required.Always)]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// Gets the different subtitles connected to their two-letter language code.
        /// Subtitles may or may not be there even if the feed has a translation for the language.
        /// </summary>
        // Todo: Make sure it works even when there's an array, if jamendo doesn't change it
        [JsonProperty(PropertyName = "subtitle", Required = Required.Always)]
        public Dictionary<string, string> Subtitle { get; private set; }

        /// <summary>
        /// Gets the Id of the feed's target entity.
        /// </summary>
        [JsonProperty(PropertyName = "joinid", Required = Required.Always)]
        public uint TargetId { get; private set; }

        /// <summary>
        /// Gets the status of the users that the feed is targeted at.
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.Always)]
        public UserStatus TargetUsers { get; private set; }

        /// <summary>
        /// Gets the different texts connected to their two-letter language code.
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        public Dictionary<string, string> Text { get; private set; }

        /// <summary>
        /// Gets the different titles connected to their two-letter language code.
        /// </summary>
        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        public Dictionary<string, string> Title { get; private set; }

        /// <summary>
        /// Gets the type (artist, album, etc.) of the feed's target entity.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public string Type { get; private set; }

        /// <summary>
        /// Represents the images object that's part of the feed result.
        /// </summary>
        public sealed class ImageOptions
        {
            /// <summary>
            /// Gets the url for the feed's cover image in the resolution 315x111.
            /// </summary>
            [JsonProperty(PropertyName = "size315_111", Required = Required.Always)]
            public string Size315x111 { get; private set; }

            /// <summary>
            /// Gets the url for the feed's cover image in the resolution 470x165.
            /// </summary>
            [JsonProperty(PropertyName = "size470_165", Required = Required.Always)]
            public string Size470x165 { get; private set; }

            /// <summary>
            /// Gets the url for the feed's cover image in the resolution 600x211.
            /// </summary>
            [JsonProperty(PropertyName = "size600_211", Required = Required.Always)]
            public string Size600x211 { get; private set; }

            /// <summary>
            /// Gets the url for the feed's cover image in the resolution 996x350.
            /// </summary>
            [JsonProperty(PropertyName = "size996_350", Required = Required.Always)]
            public string Size996x350 { get; private set; }
        }

        /// <summary>
        /// Lists the possible values for the target users field.
        /// <para/>
        /// NotLogged and Logged aren't mutually exclusive.
        /// </summary>
        [Flags]
        public enum UserStatus
        {
            /// <summary>
            /// Targets users that aren't logged in.
            /// </summary>
            NotLogged = 1,

            /// <summary>
            /// Targets users that are logged in.
            /// </summary>
            Logged = 2,

            /// <summary>
            /// Targets all users.
            /// </summary>
            All = NotLogged | Logged
        }
    }
}