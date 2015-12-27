using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the search parameter which is present in the tracks call.
    /// </summary>
    public sealed class SearchParameter : Parameter<SearchParameter, string>
    {
        public override string Name
        {
            get { return "search"; }
        }

        public SearchParameter()
            : base("")
        { }

        public SearchParameter(string search)
            : base(search)
        { }
    }
}