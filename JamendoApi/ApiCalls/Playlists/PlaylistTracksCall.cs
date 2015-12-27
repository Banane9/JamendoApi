using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Playlists;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Playlists
{
    /// <summary>
    /// Represents a call to the /playlists/tracks path.
    /// </summary>
    public sealed class PlaylistTracksCall : CallInformation<BasicPlaylist[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

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
        /// Filters playlists based on their creation date.
        /// </summary>
        public DateBetweenParameter DateBetween { get; set; }

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
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<PlaylistOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the positionbetween parameter.
        /// </summary>
        public PositionBetweenParameter PositionBetween { get; set; }

        /// <summary>
        /// Gets or sets the track_type parameter.
        /// </summary>
        public TrackTypeParameter TrackType { get; set; }

        /// <summary>
        /// Gets or sets the user_id parameter.
        /// </summary>
        public UserIdParameter UserIds { get; set; }

        /// <summary>
        /// Gets or sets the user_name parameter.
        /// </summary>
        public UserNameParameter UserName { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
                yield return AudioDownloadFormat;
                yield return AudioFormat;
                yield return DateBetween;
                yield return Ids;
                yield return ImageSize;
                yield return Limit;
                yield return Name;
                yield return Namesearch;
                yield return Offset;
                yield return Order;
                yield return PositionBetween;
                yield return TrackType;
                yield return UserIds;
                yield return UserName;
            }
        }

        public override string Path
        {
            get { return "/playlists/tracks"; }
        }

        public enum PlaylistOrder
        {
            [ApiName("name")]
            Name,

            [ApiName("id")]
            Id,

            [ApiName("creationdate")]
            CreationDate,

            [ApiName("track_id")]
            TrackId,

            [ApiName("track_name")]
            TrackName,

            [ApiName("track_position")]
            TrackPosition
        }
    }
}