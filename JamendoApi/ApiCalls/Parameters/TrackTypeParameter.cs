using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the track_type parameter which in most calls relating to tracks.
    /// </summary>
    public sealed class TrackTypeParameter : Parameter<TrackTypeParameter, TrackTypeParameter.TrackType>
    {
        public override string Name
        {
            get { return "track_type"; }
        }

        public TrackTypeParameter()
            : base(TrackType.All)
        { }

        public TrackTypeParameter(TrackType type)
            : base(type)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Select(value => value.GetName()));
        }

        /// <summary>
        /// Lists the possible values for the track type.
        /// </summary>
        public enum TrackType
        {
            [ApiName("albumtrack")]
            Albumtrack = 1,

            [ApiName("single")]
            Single = 2,

            All = Albumtrack | Single
        }
    }
}