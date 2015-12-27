using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the gender parameter which is present in the tracks call.
    /// </summary>
    public sealed class GenderParameter : Parameter<GenderParameter, Gender>
    {
        public override string Name
        {
            get { return "gender"; }
        }

        public GenderParameter()
            : base(Gender.Default)
        { }

        public GenderParameter(Gender gender)
            : base(gender)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}