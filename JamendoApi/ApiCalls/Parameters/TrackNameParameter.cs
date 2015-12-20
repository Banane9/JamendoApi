using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the track_name parameter which is present in some calls relating to tracks.
    /// </summary>
    public sealed class TrackNameParameter : Parameter<TrackNameParameter, string>
    {
        public override string Name
        {
            get { return "track_name"; }
        }

        public TrackNameParameter()
            : base("")
        { }

        public TrackNameParameter(string name)
            : base(name)
        { }
    }
}