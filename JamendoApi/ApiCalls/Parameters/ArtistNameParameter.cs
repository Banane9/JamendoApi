using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the artist_name parameter which is present in almost every call.
    /// </summary>
    public sealed class ArtistNameParameter : Parameter<ArtistNameParameter, string>
    {
        public override string Name
        {
            get { return "artist_name"; }
        }

        public ArtistNameParameter()
            : base("")
        { }

        public ArtistNameParameter(string name)
            : base(name)
        { }
    }
}