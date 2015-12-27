using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the tags parameter which is present in the tracks call.
    /// </summary>
    public sealed class FuzzyTagsParameter : Parameter<FuzzyTagsParameter, IEnumerable<string>>
    {
        public override string Name
        {
            get { return "fuzzytags"; }
        }

        public FuzzyTagsParameter()
            : base(new string[0])
        { }

        public FuzzyTagsParameter(IEnumerable<string> tags)
            : base(tags)
        { }

        public FuzzyTagsParameter(params string[] tags)
            : base(tags)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Where(tag => tag != null));
        }
    }
}