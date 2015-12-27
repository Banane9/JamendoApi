using JamendoApi.Common;
using JamendoApi.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;

namespace JamendoApi.ApiEntities.Feeds
{
    /// <summary>
    /// Represents the Feed object which is part of the /feeds/ results.
    /// <para/>
    /// Documented here: https://developer.jamendo.com/v3.0/feeds
    /// </summary>
    [JsonObject]
    public sealed class BasicFeed
    {
        private static readonly Dictionary<string, Language> languages =
                    Enum.GetValues(typeof(Language)).Cast<Language>().ToDictionary(value => value.GetName());

        [JsonProperty(PropertyName = "lang", Required = Required.Always)]
        private string[] availableLanguages = null;

        [JsonProperty(PropertyName = "subtitle", Required = Required.Always)]
        [JsonConverter(typeof(ArrayOrObjectConverter))]
        private Dictionary<string, string> subtitle = null;

        [JsonProperty(PropertyName = "text", Required = Required.Always)]
        [JsonConverter(typeof(ArrayOrObjectConverter))]
        private Dictionary<string, string> text = null;

        [JsonProperty(PropertyName = "title", Required = Required.Always)]
        [JsonConverter(typeof(ArrayOrObjectConverter))]
        private Dictionary<string, string> title = null;

        /// <summary>
        /// Gets the languages that the feed was translated to (as two-letter codes).
        /// <para/>
        /// Title, Subtitle and Text fields will contain empty values for language codes not listed here.
        /// </summary>
        [JsonIgnore]
        public Language[] AvailableLanguages { get; private set; }

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
        /// <para/>
        /// Note that there are empty entries for languages not listed under AvailableLanguages.
        /// </summary>
        [JsonIgnore]
        public ReadOnlyDictionary<Language, string> Subtitle { get; private set; }

        /// <summary>
        /// Gets the Id of the feed's target entity. 0 if the feed doesn't have a target entity.
        /// <para/>
        /// Only album, track, artist or playlist targets will have an Id.
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
        /// <para/>
        /// Note that there are empty entries for languages not listed under AvailableLanguages.
        /// </summary>
        [JsonIgnore]
        public ReadOnlyDictionary<Language, string> Text { get; private set; }

        /// <summary>
        /// Gets the different titles connected to their two-letter language code.
        /// <para/>
        /// Note that there are empty entries for languages not listed under AvailableLanguages.
        /// </summary>
        [JsonIgnore]
        public ReadOnlyDictionary<Language, string> Title { get; private set; }

        /// <summary>
        /// Gets the type (artist, album, etc.) of the feed. Defines whether it has a target entity or not.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FeedType Type { get; private set; }

        [OnDeserialized]
        private void onDeserialized(StreamingContext _)
        {
            AvailableLanguages = availableLanguages.Select(code => languages[code]).ToArray();

            Title = new ReadOnlyDictionary<Language, string>(
                title.ToDictionary(title => languages[title.Key], title => title.Value));

            Subtitle = new ReadOnlyDictionary<Language, string>(
                subtitle.ToDictionary(subtitle => languages[subtitle.Key], subtitle => subtitle.Value));

            Text = new ReadOnlyDictionary<Language, string>(
                text.ToDictionary(text => languages[text.Key], text => text.Value));
        }

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
    }
}