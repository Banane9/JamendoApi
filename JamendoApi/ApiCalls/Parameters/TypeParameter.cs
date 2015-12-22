using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the type parameter which is present in the feeds call.
    /// </summary>
    public sealed class TypeParameter : Parameter<TypeParameter, FeedType>
    {
        public override string Name
        {
            get { return "type"; }
        }

        public TypeParameter()
            : base(FeedType.All)
        { }

        public TypeParameter(FeedType type)
            : base(type)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Select(value => value.GetName()));
        }
    }
}