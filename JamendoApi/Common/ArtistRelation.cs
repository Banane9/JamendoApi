using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the type of relation.
    /// </summary>
    public enum ArtistRelation
    {
        /// <summary>
        /// The user is a fan of the artist.
        /// </summary>
        [ApiName("fan")]
        Fan
    }
}