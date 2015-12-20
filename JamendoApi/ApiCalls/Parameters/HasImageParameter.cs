using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the hasimage parameter which is present in calls relating to artists.
    /// <para/>
    /// Can only require artists have an image, not that they don't.
    /// </summary>
    public sealed class HasImageParameter : Parameter<HasImageParameter, bool>
    {
        public override string Name
        {
            get { return "hasimage"; }
        }

        public HasImageParameter()
            : base(false)
        { }

        public HasImageParameter(bool hasImage)
            : base(hasImage)
        { }

        protected override string getValueString()
        {
            return Value ? "1" : "";
        }
    }
}