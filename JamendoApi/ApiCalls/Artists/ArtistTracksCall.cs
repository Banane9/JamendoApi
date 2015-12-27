using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Artists;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Artists
{
    /// <summary>
    /// Represents a call to the /artists/tracks path.
    /// </summary>
    public sealed class ArtistTracksCall : CallInformation<TracksArtist[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the album_datebetween parameter.
        /// <para/>
        /// Filters the tracks based on their / their album's release date.
        /// </summary>
        public AlbumDateBetweenParameter AlbumDateBetween { get; set; }

        /// <summary>
        /// Gets or sets the album_id parameter.
        /// </summary>
        public AlbumIdParameter AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the album_name parameter.
        /// </summary>
        public AlbumNameParameter AlbumName { get; set; }

        /// <summary>
        /// Gets or sets the audiodlformat parameter.
        /// </summary>
        public AudioDownloadFormatParameter AudioDownloadFormat { get; set; }

        /// <summary>
        /// Gets or sets the audioformat parameter.
        /// </summary>
        public AudioFormatParameter AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the datebetween parameter.
        /// <para/>
        /// Filters artists based on their join date.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

        /// <summary>
        /// Gets or sets the hasimage parameter.
        /// </summary>
        public HasImageParameter HasImage { get; set; }

        /// <summary>
        /// Gets or sets the id parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the imagesize parameter.
        /// </summary>
        public ImageSizeParameter<CoverSize> ImageSize { get; set; }

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
        /// Gets or sets the offset parameter-
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<ArtistOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the track_id parameter.
        /// </summary>
        public TrackIdParameter TrackIds { get; set; }

        /// <summary>
        /// Gets or sets the track_name parameter.
        /// </summary>
        public TrackNameParameter TrackName { get; set; }

        /// <summary>
        /// Gets or sets the track_type parameter.
        /// </summary>
        public TrackTypeParameter TrackType { get; set; } = new TrackTypeParameter();

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AlbumDateBetween;
                yield return AlbumId;
                yield return AlbumName;
                yield return AudioDownloadFormat;
                yield return AudioFormat;
                yield return DateBetween;
                yield return HasImage;
                yield return Ids;
                yield return ImageSize;
                yield return Limit;
                yield return Name;
                yield return Namesearch;
                yield return Offset;
                yield return Order;
                yield return TrackIds;
                yield return TrackName;
                yield return TrackType;
            }
        }

        public override string Path
        {
            get { return "/artists/tracks"; }
        }

        public enum ArtistOrder
        {
            [ApiName("name")]
            Name,

            [ApiName("id")]
            Id,

            [ApiName("joindate")]
            JoinDate,

            [ApiName("popularity_total")]
            PopularityTotal,

            [ApiName("popularity_month")]
            PopularityMonth,

            [ApiName("popularity_week")]
            PopularityWeek,

            [ApiName("track_name")]
            TrackName,

            [ApiName("track_id")]
            TrackId,

            [ApiName("track_releasedate")]
            TrackReleaseDate
        }
    }
}