using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the ccnc parameter which is present in the tracks call.
    /// </summary>
    public sealed class CCNCParameter : Parameter<CCNCParameter, bool>
    {
        public override string Name
        {
            get { return "ccnc"; }
        }

        public CCNCParameter()
            : base(false)
        { }

        public CCNCParameter(bool ccnc)
            : base(ccnc)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}