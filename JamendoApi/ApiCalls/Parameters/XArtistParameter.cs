using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the xartist parameter which is present in the tracks call.
    /// </summary>
    public sealed class XArtistParameter : Parameter<XArtistParameter, string>
    {
        public override string Name
        {
            get { return "xartist"; }
        }

        public XArtistParameter()
            : base("")
        { }

        public XArtistParameter(string xartist)
            : base(xartist)
        { }
    }
}