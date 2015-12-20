using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Albums;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Albums
{
    /// <summary>
    /// Represents a call to the basic /albums/ path.
    /// </summary>
    public sealed class AlbumsCall : CallInformation<BasicAlbum[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the artist_id parameter.
        /// </summary>
        public ArtistIdParameter ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the artist_name parameter.
        /// </summary>
        public ArtistNameParameter ArtistName { get; set; }

        /// <summary>
        /// Gets or sets the datebetween parameter.
        /// <para/>
        /// Filters albums based on their release date.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

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
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<AlbumsOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the audioformat parameter.
        /// </summary>
        public ZipAudioFormatParameter ZipAudioFormat { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                if (ArtistId != null)
                    yield return ArtistId;

                if (ArtistName != null)
                    yield return ArtistName;

                if (DateBetween != null)
                    yield return DateBetween;

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
                    yield return Offset;

                if (ZipAudioFormat != null)
                    yield return ZipAudioFormat;
            }
        }

        public override string Path
        {
            get { return "/albums"; }
        }

        public enum AlbumsOrder
        {
            [ApiName("name")]
            Name,

            [ApiName("id")]
            Id,

            [ApiName("releasedate")]
            ReleaseDate,

            [ApiName("artist_id")]
            ArtistId,

            [ApiName("artist_name")]
            ArtistName,

            [ApiName("popularity_total")]
            PopularityTotal,

            [ApiName("popularity_month")]
            PopularityMonth,

            [ApiName("popularity_week")]
            PopularityWeek
        }
    }
}