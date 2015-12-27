using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the gender field.
    /// </summary>
    public enum Gender
    {
        Default,

        [ApiName("neutral")]
        Neutral,

        [ApiName("male")]
        Male,

        [ApiName("female")]
        Female
    }
}