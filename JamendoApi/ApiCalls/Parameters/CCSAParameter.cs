using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the ccsa parameter which is present in the tracks call.
    /// </summary>
    public sealed class CCSAParameter : Parameter<CCSAParameter, bool>
    {
        public override string Name
        {
            get { return "ccsa"; }
        }

        public CCSAParameter()
            : base(false)
        { }

        public CCSAParameter(bool ccsa)
            : base(ccsa)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}