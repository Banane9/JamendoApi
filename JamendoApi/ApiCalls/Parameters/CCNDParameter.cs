using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the ccnd parameter which is present in the tracks call.
    /// </summary>
    public sealed class CCNDParameter : Parameter<CCNDParameter, bool>
    {
        public override string Name
        {
            get { return "ccnd"; }
        }

        public CCNDParameter()
            : base(false)
        { }

        public CCNDParameter(bool ccnd)
            : base(ccnd)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}