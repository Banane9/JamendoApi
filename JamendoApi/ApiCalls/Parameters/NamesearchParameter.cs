using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the namesearch parameter which is present in some calls.
    /// </summary>
    public sealed class NamesearchParameter : Parameter<NamesearchParameter, string>
    {
        public override string Name
        {
            get { return "namesearch"; }
        }

        public NamesearchParameter()
            : base("")
        { }

        public NamesearchParameter(string name)
            : base(name)
        { }
    }
}