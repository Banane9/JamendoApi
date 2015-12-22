using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the target parameter which is present in the feeds call.
    /// </summary>
    public sealed class TargetParameter : Parameter<TargetParameter, UserStatus>
    {
        public override string Name
        {
            get { return "target"; }
        }

        public TargetParameter()
            : base(UserStatus.All)
        { }

        public TargetParameter(UserStatus status)
            : base(status)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}