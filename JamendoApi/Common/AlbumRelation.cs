using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the type of relation.
    /// </summary>
    public enum AlbumRelation
    {
        /// <summary>
        /// The user has added the album to his My Albums list.
        /// </summary>
        [ApiName("myalbums")]
        MyAlbums
    }
}