using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the location_city parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class LocationCityParameter : Parameter<LocationCityParameter, string>
    {
        public override string Name
        {
            get { return "location_city"; }
        }

        public LocationCityParameter()
            : base("")
        { }

        public LocationCityParameter(string city)
            : base(city)
        { }
    }
}