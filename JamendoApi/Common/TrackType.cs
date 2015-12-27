using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the track type.
    /// </summary>
    public enum TrackType
    {
        [ApiName("albumtrack")]
        Albumtrack = 1,

        [ApiName("single")]
        Single = 2,

        [ApiName("single+albumtrack")]
        All = Albumtrack | Single
    }
}