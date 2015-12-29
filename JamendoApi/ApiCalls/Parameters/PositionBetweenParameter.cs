using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the positionbetween parameter which is present in the /playlists/tracks call.
    /// </summary>
    public sealed class PositionBetweenParameter : Parameter<PositionBetweenParameter, PositionBetweenParameter.PositionBetween>
    {
        public override string Name
        {
            get { return "positionbetween"; }
        }

        public PositionBetweenParameter()
            : base(new PositionBetween(0, uint.MaxValue))
        { }

        public PositionBetweenParameter(PositionBetween positionBetween)
            : base(positionBetween)
        { }

        /// <summary>
        /// Represents the value for the positionbetween parameter.
        /// </summary>
        public sealed class PositionBetween
        {
            public uint EndPosition { get; set; }
            public uint StartPosition { get; set; }

            public PositionBetween(uint startPosition, uint endPosition)
            {
                StartPosition = startPosition;
                EndPosition = endPosition;
            }

            public override string ToString()
            {
                return $"{StartPosition}_{EndPosition}";
            }
        }
    }
}