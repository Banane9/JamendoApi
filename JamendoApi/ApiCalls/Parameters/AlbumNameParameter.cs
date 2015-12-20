using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the album_name parameter which is present in some calls relating to tracks and artists.
    /// </summary>
    public sealed class AlbumNameParameter : Parameter<AlbumNameParameter, string>
    {
        public override string Name
        {
            get { return "album_name"; }
        }

        public AlbumNameParameter()
            : base("")
        { }

        public AlbumNameParameter(string name)
            : base(name)
        { }
    }
}