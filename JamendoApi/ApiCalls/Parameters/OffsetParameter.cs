using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the offset parameter which is part of nearly all calls.
    /// </summary>
    public sealed class OffsetParameter : Parameter<OffsetParameter, uint>
    {
        public override string Name
        {
            get { return "offset"; }
        }

        public OffsetParameter()
            : base(0)
        { }

        public OffsetParameter(uint value)
            : base(value)
        { }

        protected override string getValueString()
        {
            return Value.ToString();
        }
    }
}