using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the include parameter which is present in the tracks call.
    /// </summary>
    public sealed class IncludeParameter : Parameter<IncludeParameter, IncludeParameter.Include>
    {
        public override string Name
        {
            get { return "include"; }
        }

        public IncludeParameter()
            : base(Include.None)
        { }

        public IncludeParameter(Include include)
            : base(include)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Select(value => value.GetName()));
        }

        [Flags]
        public enum Include
        {
            None,

            [ApiName("licenses")]
            Licenses = 1,

            [ApiName("musicinfo")]
            MusicInfo = 2,

            [ApiName("stats")]
            Stats = 4,

            [ApiName("lyrics")]
            Lyrics = 8,

            All = Licenses | MusicInfo | Stats | Lyrics
        }
    }
}