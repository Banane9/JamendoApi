using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the artist_id parameter which is present in calls relating to albums and tracks.
    /// </summary>
    public sealed class ArtistIdParameter : Parameter<ArtistIdParameter, IEnumerable<uint>>
    {
        public override string Name
        {
            get { return "artist_id"; }
        }

        public ArtistIdParameter()
            : base(new uint[0])
        { }

        public ArtistIdParameter(params uint[] ids)
            : base(ids)
        { }

        public ArtistIdParameter(IEnumerable<uint> ids)
            : base(ids)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Select(id => id.ToString()));
        }
    }
}