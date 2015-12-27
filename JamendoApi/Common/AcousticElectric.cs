using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the acousticelectric field.
    /// </summary>
    public enum AcousticElectric
    {
        Default,

        [ApiName("acoustic")]
        Acoustic,

        [ApiName("electric")]
        Electric
    }
}