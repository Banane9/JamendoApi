using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the target type of feeds.
    /// </summary>
    [Flags]
    public enum FeedType
    {
        [ApiName("album")]
        Album = 1,

        [ApiName("artist")]
        Artist = 2,

        [ApiName("playlist")]
        Playlist = 4,

        [ApiName("track")]
        Track = 8,

        [ApiName("news")]
        News = 16,

        [ApiName("interview")]
        Interview = 32,

        [ApiName("contest")]
        Contest = 64,

        [ApiName("video")]
        Video = 128,

        [ApiName("update")]
        Update = 256,

        All = Album | Artist | Playlist | Track | News | Interview | Contest | Video | Update
    }
}