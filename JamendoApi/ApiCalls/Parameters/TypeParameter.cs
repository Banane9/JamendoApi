using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the type parameter which is present in the feeds call.
    /// </summary>
    public sealed class TypeParameter<TType> : Parameter<TypeParameter<TType>, TType>
    {
        public override string Name
        {
            get { return "type"; }
        }

        public TypeParameter()
            : base(default(TType))
        { }

        public TypeParameter(TType type)
            : base(type)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Cast<Enum>().Select(value => value.GetName()));
        }
    }
}