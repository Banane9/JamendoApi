using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the acousticelectric parameter which is present in the tracks call.
    /// </summary>
    public sealed class AcousticElectricParameter : Parameter<AcousticElectricParameter, AcousticElectric>
    {
        public override string Name
        {
            get { return "acousticelectric"; }
        }

        public AcousticElectricParameter()
            : base(AcousticElectric.Default)
        { }

        public AcousticElectricParameter(AcousticElectric acousticElectric)
            : base(acousticElectric)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}