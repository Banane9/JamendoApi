using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Albums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Albums
{
    public class AlbumsCall : CallInformation<BasicAlbum>
    {
        public OffsetParameter Offset { get; set; }

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                if (Offset != null)
                    yield return Offset;
            }
        }

        public override string Path
        {
            get { return "albums"; }
        }
    }
}