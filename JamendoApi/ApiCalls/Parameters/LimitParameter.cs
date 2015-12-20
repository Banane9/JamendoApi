using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the limit parameter which is present in nearly all calls.
    /// </summary>
    public sealed class LimitParameter : Parameter<LimitParameter, uint>
    {
        public const uint MaxLimit = 200;
        public const uint MinLimit = 1;

        public override string Name
        {
            get { return "limit"; }
        }

        public LimitParameter()
            : base(10)
        { }

        public LimitParameter(uint limit)
            : base(Math.Max(MinLimit, Math.Min(MaxLimit, limit)))
        { }
    }
}