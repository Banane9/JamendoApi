using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the speed parameter which is present in the tracks call.
    /// </summary>
    public sealed class SpeedParameter : Parameter<SpeedParameter, Tempo>
    {
        public override string Name
        {
            get { return "speed"; }
        }

        public SpeedParameter()
            : base(Tempo.Default)
        { }

        public SpeedParameter(Tempo speed)
            : base(speed)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}