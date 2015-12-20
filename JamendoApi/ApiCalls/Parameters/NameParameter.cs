using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the name parameter which is present in almost every call.
    /// </summary>
    public sealed class NameParameter : Parameter<NameParameter, string>
    {
        public override string Name
        {
            get { return "name"; }
        }

        public NameParameter()
            : base("")
        { }

        public NameParameter(string name)
            : base(name)
        { }
    }
}