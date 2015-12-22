using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the access_token parameter which is present in calls relating to users.
    /// </summary>
    public sealed class AccessTokenParameter : Parameter<AccessTokenParameter, string>
    {
        public override string Name
        {
            get { return "access_token"; }
        }

        public AccessTokenParameter()
            : base("")
        { }

        public AccessTokenParameter(string token)
            : base(token)
        { }
    }
}