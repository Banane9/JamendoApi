using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the track_id parameter which is present in nearly all calls.
    /// </summary>
    public sealed class TrackIdParameter : Parameter<TrackIdParameter, IEnumerable<uint>>
    {
        public override string Name
        {
            get { return "track_id"; }
        }

        public TrackIdParameter()
            : base(new uint[0])
        { }

        public TrackIdParameter(params uint[] ids)
            : base(ids)
        { }

        public TrackIdParameter(IEnumerable<uint> ids)
            : base(ids)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Select(id => id.ToString()));
        }
    }
}