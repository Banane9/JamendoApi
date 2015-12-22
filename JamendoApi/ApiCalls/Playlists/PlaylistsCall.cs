using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Playlists;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Playlists
{
    /// <summary>
    /// Represents a call to the basic /playlists path.
    /// </summary>
    public sealed class PlaylistsCall : CallInformation<BasicPlaylist[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the datebetween parameter.
        /// <para/>
        /// Filters playlists based on their creation date.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

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
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<PlaylistOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the user_id parameter.
        /// </summary>
        public UserIdParameter UserIds { get; set; }

        /// <summary>
        /// Gets or sets the user_name parameter.
        /// </summary>
        public UserNameParameter UserName { get; set; }

        /// <summary>
        /// Gets or sets the audioformat parameter.
        /// </summary>
        public ZipAudioFormatParameter ZipAudioFormat { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
                yield return DateBetween;
                yield return Ids;
                yield return Limit;
                yield return Name;
                yield return Namesearch;
                yield return Offset;
                yield return Order;
                yield return UserIds;
                yield return UserName;
                yield return ZipAudioFormat;
            }
        }

        public override string Path
        {
            get { return "/playlists"; }
        }

        public enum PlaylistOrder
        {
            [ApiName("name")]
            Name,

            [ApiName("id")]
            Id,

            [ApiName("creationdate")]
            CreationDate
        }
    }
}