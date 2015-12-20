using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the tag parameter which is present in some calls relating to tracks and musicinfo.
    /// </summary>
    public sealed class TagParameter : Parameter<TagParameter, string>
    {
        public override string Name
        {
            get { return "tag"; }
        }

        public TagParameter()
            : base("")
        { }

        public TagParameter(string tag)
            : base(tag)
        { }
    }
}