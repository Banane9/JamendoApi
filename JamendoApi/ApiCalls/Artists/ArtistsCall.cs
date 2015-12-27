using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Artists;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Artists
{
    /// <summary>
    /// Represents a call to the basic /artists/ path.
    /// </summary>
    public sealed class ArtistsCall : CallInformation<BasicArtist[]>
    {
        #region Parameters

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
                yield return DateBetween;
                yield return HasImage;
                yield return Ids;
                yield return Limit;
                yield return Name;
                yield return Namesearch;
                yield return Offset;
                yield return Order;
            }
        }

        public override string Path
        {
            get { return "/artists"; }
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
            PopularityWeek
        }
    }
}