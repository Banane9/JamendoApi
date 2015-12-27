using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Users;
using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Users
{
    /// <summary>
    /// Represents a call to the /users/albums path.
    /// </summary>
    public sealed class UserAlbumsCall : CallInformation<AlbumsUser[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the album_ids parameter.
        /// </summary>
        public AlbumIdParameter AlbumIds { get; set; }

        /// <summary>
        /// Gets or sets the album_imagesize parameter.
        /// </summary>
        public ImageSizeParameter<CoverSize> AlbumImageSize { get; set; }

        /// <summary>
        /// Gets or sets the artist_id parameter.
        /// </summary>
        public ArtistIdParameter ArtistIds { get; set; }

        /// <summary>
        /// Gets or sets the id parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the imagesize parameter.
        /// </summary>
        public ImageSizeParameter<AvatarSize> ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the name parameter.
        /// </summary>
        public NameParameter Name { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<AlbumOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the relation parameter.
        /// </summary>
        public RelationParameter<AlbumRelation> Relation { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
                yield return AlbumIds;
                yield return AlbumImageSize;
                yield return ArtistIds;
                yield return Ids;
                yield return ImageSize;
                yield return Limit;
                yield return Name;
                yield return Offset;
                yield return Order;
                yield return Relation;
            }
        }

        public override string Path
        {
            get { return "/users/albums"; }
        }

        public UserAlbumsCall(IdParameter ids)
        {
            if (ids == null)
                throw new ArgumentNullException(nameof(ids), "Ids can't be null.");

            Ids = ids;
        }

        public UserAlbumsCall(AccessTokenParameter accessToken)
        {
            if (accessToken == null)
                throw new ArgumentNullException(nameof(accessToken), "AccessToken can't be null.");

            AccessToken = accessToken;
        }

        public UserAlbumsCall(NameParameter name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name), "Name can't be null.");

            Name = name;
        }

        public enum AlbumOrder
        {
            [ApiName("updatedate")]
            UpdateDate
        }
    }
}