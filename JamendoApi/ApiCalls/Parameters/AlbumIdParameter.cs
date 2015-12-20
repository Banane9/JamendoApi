using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the album_id parameter which is present in some calls relating to tracks and artists.
    /// </summary>
    public sealed class AlbumIdParameter : Parameter<AlbumIdParameter, IEnumerable<uint>>
    {
        public override string Name
        {
            get { return "album_id"; }
        }

        public AlbumIdParameter()
            : base(new uint[0])
        { }

        public AlbumIdParameter(params uint[] ids)
            : base(ids)
        { }

        public AlbumIdParameter(IEnumerable<uint> ids)
            : base(ids)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Select(id => id.ToString()));
        }
    }
}