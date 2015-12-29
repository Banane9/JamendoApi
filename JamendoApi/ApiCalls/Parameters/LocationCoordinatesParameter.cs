using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the location_coords parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class LocationCoordinatesParameter : Parameter<LocationCoordinatesParameter, LocationCoordinatesParameter.Coordinates>
    {
        public override string Name
        {
            get { return "location_coords"; }
        }

        public LocationCoordinatesParameter()
            : base(new Coordinates())
        { }

        public LocationCoordinatesParameter(Coordinates coordinates)
            : base(coordinates)
        { }

        public sealed class Coordinates
        {
            public float Latitude { get; set; }

            public float Longitude { get; set; }

            public override string ToString()
            {
                return $"{Latitude}_{Longitude}";
            }
        }
    }
}