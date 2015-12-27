using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the featured parameter which is present in the tracks call.
    /// </summary>
    public sealed class FeaturedParameter : Parameter<FeaturedParameter, bool>
    {
        public override string Name
        {
            get { return "featured"; }
        }

        public FeaturedParameter()
            : base(false)
        { }

        public FeaturedParameter(bool featured)
            : base(featured)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}