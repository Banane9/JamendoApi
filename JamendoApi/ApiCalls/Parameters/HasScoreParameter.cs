using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the hasscore parameter which is present in calls relating to reviews.
    /// </summary>
    public sealed class HasScoreParameter : Parameter<HasScoreParameter, bool>
    {
        public override string Name
        {
            get { return "hasscore"; }
        }

        public HasScoreParameter()
            : base(true)
        { }

        public HasScoreParameter(bool hasScore)
            : base(hasScore)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "false";
        }
    }
}