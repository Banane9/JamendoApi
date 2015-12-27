using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the value for *datebetween parameters.
    /// </summary>
    public sealed class DateBetween
    {
        public const string DateFormat = "yyyy-MM-dd";

        public DateTime End { get; set; }
        public DateTime Start { get; set; }

        public DateBetween(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        internal DateBetween()
        {
            Start = new DateTime(0);
            End = new DateTime(long.MaxValue);
        }

        public override string ToString()
        {
            return Start.ToString(DateFormat) + "_" + End.ToString(DateFormat);
        }
    }

    /// <summary>
    /// Represents the datebetween parameter which is present in many calls.
    /// </summary>
    public sealed class DateBetweenParameter : Parameter<DateBetweenParameter, DateBetween>
    {
        public override string Name
        {
            get { return "datebetween"; }
        }

        public DateBetweenParameter()
            : base(new DateBetween())
        { }

        public DateBetweenParameter(DateBetween dateBetween)
            : base(dateBetween)
        { }

        public DateBetweenParameter(DateTime start, DateTime end)
            : base(new DateBetween(start, end))
        { }
    }
}