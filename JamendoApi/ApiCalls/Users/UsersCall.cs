using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Users
{
    /// <summary>
    /// Represents a call to the basic /users path.
    /// </summary>
    public sealed class UsersCall : CallInformation<BasicUser[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the access_token parameter.
        /// </summary>
        public AccessTokenParameter AccessToken { get; set; }

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

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AccessToken;
                yield return Ids;
                yield return ImageSize;
                yield return Limit;
                yield return Name;
                yield return Offset;
            }
        }

        public override string Path
        {
            get { return "/users"; }
        }
    }
}