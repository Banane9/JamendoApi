﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiParts.Radios
{
    /// <summary>
    /// Lists the possible values for the radio type.
    /// </summary>
    public enum RadioType
    {
        /// <summary>
        /// Featured jamendo radios. Available to everyone.
        /// </summary>
        WWW,

        /// <summary>
        /// For commercial stores and places only.
        /// <para/>
        /// Requires special privileges for your app to be accessed.
        /// </summary>
        Pro
    }
}