using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Tracks;
using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Tracks
{
    /// <summary>
    /// Represents a call to the basic /tracks path.
    /// </summary>
    public sealed class TracksCall : CallInformation<BasicTrack[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the acousticelectric parameter.
        /// </summary>
        public AcousticElectricParameter AcousticElectric { get; set; }

        /// <summary>
        /// Gets or sets the album_id parameter.
        /// </summary>
        public AlbumIdParameter AlbumIds { get; set; }

        /// <summary>
        /// Gets or sets the album_name parameter.
        /// </summary>
        public AlbumNameParameter AlbumName { get; set; }

        /// <summary>
        /// Gets or sets the artist_id parameter.
        /// </summary>
        public ArtistIdParameter ArtistIds { get; set; }

        /// <summary>
        /// Gets or sets the artist_name parameter.
        /// </summary>
        public ArtistNameParameter ArtistName { get; set; }

        /// <summary>
        /// Gets or sets the audiodlformat parameter.
        /// </summary>
        public AudioDownloadFormatParameter AudioDownloadFormat { get; set; }

        /// <summary>
        /// Gets or sets the aduioformat parameter.
        /// </summary>
        public AudioFormatParameter AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the boost parameter.
        /// </summary>
        public BoostParameter Boost { get; set; }

        /// <summary>
        /// Gets or sets the ccnc parameter.
        /// </summary>
        public CCNCParameter CCNC { get; set; }

        /// <summary>
        /// Gets or sets the ccnd parameter.
        /// </summary>
        public CCNDParameter CCND { get; set; }

        /// <summary>
        /// Gets or sets the ccsa parameter.
        /// </summary>
        public CCSAParameter CCSA { get; set; }

        /// <summary>
        /// Gets or sets the datebetween parameter.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

        /// <summary>
        /// Gets or sets the durationbetween parameter.
        /// </summary>
        public DurationBetweenParameter DurationBetween { get; set; }

        /// <summary>
        /// Gets or sets the featured parameter.
        /// </summary>
        public FeaturedParameter Featured { get; set; }

        /// <summary>
        /// Gets or sets the fuzzytags parameter.
        /// </summary>
        public FuzzyTagsParameter FuzzyTags { get; set; }

        /// <summary>
        /// Gets or sets the gender parameter.
        /// </summary>
        public GenderParameter Gender { get; set; }

        /// <summary>
        /// Gets or sets the groupby parameter.
        /// </summary>
        public GroupByParameter GroupBy { get; set; }

        /// <summary>
        /// Gets or sets the id parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the imagesize parameter.
        /// </summary>
        public ImageSizeParameter<CoverSize> ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the include parameter.
        /// </summary>
        public IncludeParameter Include { get; set; }

        /// <summary>
        /// Gets or sets the language parameter.
        /// </summary>
        public LanguageParameter Language { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the name parameter.
        /// </summary>
        public NameParameter Name { get; set; }

        /// <summary>
        /// Gets or sets the namesearch parameter.
        /// </summary>
        public NamesearchParameter Namesearch { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<TrackOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the probackground parameter.
        /// </summary>
        public ProBackgroundParameter ProBackground { get; set; }

        /// <summary>
        /// Gets or sets the prolicensing parameter.
        /// </summary>
        public ProLicensingParameter ProLicensing { get; set; }

        /// <summary>
        /// Gets or sets the search parameter.
        /// </summary>
        public SearchParameter Search { get; set; }

        /// <summary>
        /// Gets or sets the speed parameter.
        /// </summary>
        public SpeedParameter Speed { get; set; }

        /// <summary>
        /// Gets or sets the tags parameter.
        /// </summary>
        public TagsParameter Tags { get; set; }

        /// <summary>
        /// Gets or sets the type parameter.
        /// </summary>
        public TypeParameter<TrackType> Type { get; set; }

        /// <summary>
        /// Gets or sets the vocalinstrumental parameter.
        /// </summary>
        public VocalInstrumentalParameter VocalInstrumental { get; set; }

        /// <summary>
        /// Gets or sets the xartist parameter.
        /// </summary>
        public XArtistParameter XArtist { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AcousticElectric;
                yield return AlbumIds;
                yield return AlbumName;
                yield return ArtistIds;
                yield return ArtistName;
                yield return AudioDownloadFormat;
                yield return AudioFormat;
                yield return Boost;
                yield return CCNC;
                yield return CCND;
                yield return CCSA;
                yield return DateBetween;
                yield return DurationBetween;
                yield return Featured;
                yield return FuzzyTags;
                yield return Gender;
                yield return GroupBy;
                yield return Ids;
                yield return ImageSize;
                yield return Include;
                yield return Language;
                yield return Limit;
                yield return Name;
                yield return Namesearch;
                yield return Offset;
                yield return Order;
                yield return ProBackground;
                yield return ProLicensing;
                yield return Search;
                yield return Speed;
                yield return Tags;
                yield return Type;
                yield return VocalInstrumental;
                yield return XArtist;
            }
        }

        public override string Path
        {
            get { return "/tracks"; }
        }

        public enum TrackOrder
        {
            [ApiName("relevance")]
            Relevance,

            [ApiName("buzzrate")]
            Buzzrate,

            [ApiName("downloads_week")]
            DownloadsWeek,

            [ApiName("downloads_month")]
            DownloadsMonth,

            [ApiName("downloads_total")]
            DownloadsTotal,

            [ApiName("listens_week")]
            ListensWeek,

            [ApiName("listens_month")]
            ListensMonth,

            [ApiName("listens_total")]
            ListensTotal,

            [ApiName("popularity_week")]
            PopularityWeek,

            [ApiName("popularity_month")]
            PopularityMonth,

            [ApiName("popularity_total")]
            PopularityTotal,

            [ApiName("name")]
            Name,

            [ApiName("album_name")]
            AlbumName,

            [ApiName("artist_name")]
            ArtistName,

            [ApiName("releasedate")]
            ReleaseDate,

            [ApiName("duration")]
            Duration,

            [ApiName("id")]
            Id
        }
    }
}