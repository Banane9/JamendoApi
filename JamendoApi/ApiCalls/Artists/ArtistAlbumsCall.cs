using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Artists;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Artists
{
    /// <summary>
    /// Represents a call to the /artists/albums path.
    /// </summary>
    public sealed class ArtistAlbumsCall : CallInformation<TracksArtist[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the album_datebetween parameter.
        /// <para/>
        /// Filters the albums based on their release date.
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
            }
        }

        public override string Path
        {
            get { return "/artists/albums"; }
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

            [ApiName("album_name")]
            AlbumName,

            [ApiName("album_id")]
            AlbumId,

            [ApiName("album_releasedate")]
            AlbumReleaseDate
        }
    }
}