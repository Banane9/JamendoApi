using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the vocalinstrumental field.
    /// </summary>
    public enum VocalInstrumental
    {
        Default,

        [ApiName("vocal")]
        Vocal,

        [ApiName("instrumental")]
        Instrumental
    }
}