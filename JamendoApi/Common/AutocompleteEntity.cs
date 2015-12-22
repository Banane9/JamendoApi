using JamendoApi.Util;
using System;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the autocomplete entities.
    /// </summary>
    [Flags]
    public enum AutocompleteEntity
    {
        [ApiName("tags")]
        Tags = 1,

        [ApiName("artists")]
        Artists = 2,

        [ApiName("tracks")]
        Tracks = 4,

        [ApiName("albums")]
        Albums = 8,

        All = Tags | Artists | Tracks | Albums
    }
}