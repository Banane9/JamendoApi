using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the tags parameter which is present in the tracks call.
    /// </summary>
    public sealed class TagsParameter : Parameter<TagsParameter, IEnumerable<string>>
    {
        public override string Name
        {
            get { return "tags"; }
        }

        public TagsParameter()
            : base(new string[0])
        { }

        public TagsParameter(IEnumerable<string> tags)
            : base(tags)
        { }

        public TagsParameter(params string[] tags)
            : base(tags)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Where(tag => tag != null));
        }
    }
}