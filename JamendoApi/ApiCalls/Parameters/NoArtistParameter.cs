using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the no_artist parameter which is present in the /tracks/similar call.
    /// </summary>
    public sealed class NoArtistParameter : Parameter<NoArtistParameter, uint>
    {
        public override string Name
        {
            get { return "no_artist"; }
        }

        public NoArtistParameter()
            : base(0)
        { }

        public NoArtistParameter(uint id)
            : base(id)
        { }
    }
}