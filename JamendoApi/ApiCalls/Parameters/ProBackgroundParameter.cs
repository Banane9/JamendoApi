using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the probackground parameter which is present in the tracks call.
    /// </summary>
    public sealed class ProBackgroundParameter : Parameter<ProBackgroundParameter, bool>
    {
        public override string Name
        {
            get { return "probackground"; }
        }

        public ProBackgroundParameter()
            : base(false)
        { }

        public ProBackgroundParameter(bool proBackground)
            : base(proBackground)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}