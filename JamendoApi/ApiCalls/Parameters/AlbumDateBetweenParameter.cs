using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the album_datebetween parameter which is some calls relating to tracks or artists.
    /// </summary>
    public sealed class AlbumDateBetweenParameter : Parameter<DateBetweenParameter, DateBetween>
    {
        public override string Name
        {
            get { return "album_datebetween"; }
        }

        public AlbumDateBetweenParameter()
            : base(new DateBetween())
        { }

        public AlbumDateBetweenParameter(DateBetween dateBetween)
            : base(dateBetween)
        { }

        public AlbumDateBetweenParameter(DateTime start, DateTime end)
            : base(new DateBetween(start, end))
        { }

        protected override string getValueString()
        {
            return Value.ToString();
        }
    }
}