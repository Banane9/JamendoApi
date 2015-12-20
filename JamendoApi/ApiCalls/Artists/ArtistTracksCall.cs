using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Artists;
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
        public CoverImageSizeParameter ImageSize { get; set; }

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
                if (AlbumDateBetween != null)
                    yield return AlbumDateBetween;

                if (AlbumId != null)
                    yield return AlbumId;

                if (AlbumName != null)
                    yield return AlbumName;

                if (AudioDownloadFormat != null)
                    yield return AudioDownloadFormat;

                if (AudioFormat != null)
                    yield return AudioFormat;

                if (DateBetween != null)
                    yield return DateBetween;

                if (HasImage != null)
                    yield return HasImage;

                if (Ids != null)
                    yield return Ids;

                if (ImageSize != null)
                    yield return ImageSize;

                if (Limit != null)
                    yield return Limit;

                if (Name != null)
                    yield return Name;

                if (Namesearch != null)
                    yield return Namesearch;

                if (Offset != null)
                    yield return Offset;

                if (Order != null)
                    yield return Order;

                if (TrackIds != null)
                    yield return TrackIds;

                if (TrackName != null)
                    yield return TrackName;

                if (TrackType != null)
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