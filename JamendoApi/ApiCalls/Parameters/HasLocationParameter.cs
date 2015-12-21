using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the haslocation parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class HasLocationParameter : Parameter<HasLocationParameter, bool>
    {
        public override string Name
        {
            get { return "haslocation"; }
        }

        public HasLocationParameter()
            : base(true)
        { }

        public HasLocationParameter(bool hasLocation)
            : base(hasLocation)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "false";
        }
    }
}