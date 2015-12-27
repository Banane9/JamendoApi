using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the speed field.
    /// </summary>
    public enum Tempo
    {
        Default,

        [ApiName("verylow")]
        VeryLow,

        [ApiName("low")]
        Low,

        [ApiName("medium")]
        Medium,

        [ApiName("high")]
        High,

        [ApiName("veryhigh")]
        VeryHigh
    }
}