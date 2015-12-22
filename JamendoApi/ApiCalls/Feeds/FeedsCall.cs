using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Feeds;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Feeds
{
    /// <summary>
    /// Represents a call to the basic /feeds path.
    /// </summary>
    public sealed class FeedsCall : CallInformation<BasicFeed[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the id parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the lang parameter.
        /// </summary>
        public LanguageParameter Language { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<FeedOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the target parameter.
        /// </summary>
        public TargetParameter Target { get; set; }

        /// <summary>
        /// Gets or sets the type parameter.
        /// </summary>
        public TypeParameter Type { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return Ids;
                yield return Language;
                yield return Limit;
                yield return Offset;
                yield return Order;
                yield return Target;
                yield return Type;
            }
        }

        public override string Path
        {
            get { return "/feeds"; }
        }

        public enum FeedOrder
        {
            [ApiName("id")]
            Id,

            [ApiName("date_start")]
            StartDate,

            [ApiName("date_end")]
            EndDate,

            [ApiName("position")]
            Position
        }
    }
}