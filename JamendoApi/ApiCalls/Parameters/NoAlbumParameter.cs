using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the no_album parameter which is present in the /tracks/similar call.
    /// </summary>
    public sealed class NoAlbumParameter : Parameter<NoAlbumParameter, uint>
    {
        public override string Name
        {
            get { return "no_album"; }
        }

        public NoAlbumParameter()
            : base(0)
        { }

        public NoAlbumParameter(uint id)
            : base(id)
        { }
    }
}