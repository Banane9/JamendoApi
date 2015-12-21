using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the location_radius parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class LocationRadiusParameter : Parameter<LocationRadiusParameter, uint>
    {
        public override string Name
        {
            get { return "location_radius"; }
        }

        public LocationRadiusParameter()
            : base(0)
        { }

        public LocationRadiusParameter(uint radius)
            : base(radius)
        { }
    }
}