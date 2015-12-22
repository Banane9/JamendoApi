using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the user_id parameter which is present in calls relating to users.
    /// </summary>
    public sealed class UserIdParameter : Parameter<UserIdParameter, IEnumerable<uint>>
    {
        public override string Name
        {
            get { return "user_id"; }
        }

        public UserIdParameter()
            : base(new uint[0])
        { }

        public UserIdParameter(params uint[] ids)
            : base(ids)
        { }

        public UserIdParameter(IEnumerable<uint> ids)
            : base(ids)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Select(id => id.ToString()));
        }
    }
}