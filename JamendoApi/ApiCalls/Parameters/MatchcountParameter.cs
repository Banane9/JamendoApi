using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the matchcount parameter which is present in the autocomplete call.
    /// </summary>
    public sealed class MatchcountParameter : Parameter<MatchcountParameter, bool>
    {
        public override string Name
        {
            get { return "matchcount"; }
        }

        public MatchcountParameter()
            : base(true)
        { }

        internal MatchcountParameter(bool count)
            : base(count)
        { }
    }
}