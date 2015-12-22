using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Common
{
    /// <summary>
    /// Lists the possible values for the target users of feeds.
    /// <para/>
    /// NotLogged and Logged aren't mutually exclusive.
    /// </summary>
    [Flags]
    public enum UserStatus
    {
        /// <summary>
        /// Targets users that aren't logged in.
        /// </summary>
        [ApiName("notlogged")]
        NotLogged = 1,

        /// <summary>
        /// Targets users that are logged in.
        /// </summary>
        [ApiName("logged")]
        Logged = 2,

        /// <summary>
        /// Targets all users.
        /// </summary>
        [ApiName("all")]
        All = NotLogged | Logged
    }
}