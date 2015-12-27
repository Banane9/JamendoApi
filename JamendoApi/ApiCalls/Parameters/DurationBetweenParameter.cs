using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the durationbetween parameter which is present in the tracks call.
    /// </summary>
    public sealed class DurationBetweenParameter : Parameter<DurationBetweenParameter, DurationBetweenParameter.DurationBetween>
    {
        public override string Name
        {
            get { return "durationbetween"; }
        }

        public DurationBetweenParameter()
            : base(new DurationBetween())
        { }

        public DurationBetweenParameter(DurationBetween durationBetween)
            : base(durationBetween)
        { }

        /// <summary>
        /// Represents the value of the durationbetween parameter.
        /// </summary>
        public sealed class DurationBetween
        {
            public uint End { get; set; }
            public uint Start { get; set; }

            public DurationBetween(uint start = 0, uint end = uint.MaxValue)
            {
                Start = start;
                End = end;
            }

            public override string ToString()
            {
                return Start.ToString() + "_" + End.ToString();
            }
        }
    }
}