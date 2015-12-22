using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the user_name parameter which is present in calls relating to users.
    /// </summary>
    public sealed class UserNameParameter : Parameter<UserNameParameter, string>
    {
        public override string Name
        {
            get { return "user_name"; }
        }

        public UserNameParameter()
            : base("")
        { }

        public UserNameParameter(string name)
            : base(name)
        { }
    }
}