using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the type of relation.
    /// </summary>
    public enum TrackRelation
    {
        /// <summary>
        /// User has reviewed the track.
        /// <para/>
        /// The value is the score that the user gave it, from 1 to 10.
        /// </summary>
        [ApiName("review")]
        Review,

        /// <summary>
        /// User has favorited the track.
        /// </summary>
        [ApiName("favorite")]
        Favorite,

        /// <summary>
        /// User liked the track.
        /// </summary>
        [ApiName("like")]
        Like
    }
}