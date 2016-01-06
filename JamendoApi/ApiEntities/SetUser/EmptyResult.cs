using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JamendoApi.ApiEntities.SetUser
{
    /// <summary>
    /// Represents the empty result which is part of the /setuser/* results.
    /// </summary>
    [JsonObject]
    public sealed class EmptyResult
    {
        /// <summary>
        /// This shouldn't ever be instantiated because the results field should always be empty.
        /// </summary>
        public EmptyResult()
        {
            if (Debugger.IsAttached)
                Debugger.Break();
        }
    }
}