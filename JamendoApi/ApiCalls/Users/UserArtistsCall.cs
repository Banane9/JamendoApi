using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Users;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Users
{
    /// <summary>
    /// Represents a call to the /users/artists path.
    /// </summary>
    public sealed class UserArtistsCall : CallInformation<ArtistsUser[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

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
        public OrderParameter<ArtistOrder> Order { get; set; }

        /// <summary>
        /// Gets or sets the relation parameter.
        /// </summary>
        public RelationParameter<ArtistRelation> Relation { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
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
            get { return "/users/artists"; }
        }

        public UserArtistsCall(IdParameter ids)
        {
            if (ids == null)
                throw new ArgumentNullException(nameof(ids), "Ids can't be null.");

            Ids = ids;
        }

        public UserArtistsCall(AccessTokenParameter accessToken)
        {
            if (accessToken == null)
                throw new ArgumentNullException(nameof(accessToken), "AccessToken can't be null.");

            AccessToken = accessToken;
        }

        public UserArtistsCall(NameParameter name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name), "Name can't be null.");

            Name = name;
        }

        public enum ArtistOrder
        {
            [ApiName("updatedate")]
            UpdateDate
        }

        public enum ArtistRelation
        {
            [ApiName("fan")]
            Fan
        }
    }
}