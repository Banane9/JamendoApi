using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the prefix parameter which is present in the autocomplete call.
    /// <para/>
    /// Prefix is used like: where `Name` LIKE 'prefix%'
    /// <para/>
    /// Minimum is a two letter string.
    /// </summary>
    public sealed class PrefixParameter : Parameter<PrefixParameter, string>
    {
        public override string Name
        {
            get { return "prefix"; }
        }

        public PrefixParameter()
            : base("")
        { }

        public PrefixParameter(string prefix)
            : base(prefix)
        { }
    }
}