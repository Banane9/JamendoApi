using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the id parameter which is present in calls relating to locations.
    /// </summary>
    public sealed class IdParameter : Parameter<IdParameter, IEnumerable<uint>>
    {
        public override string Name
        {
            get { return "id"; }
        }

        public IdParameter()
            : base(new uint[0])
        { }

        public IdParameter(params uint[] ids)
            : base(ids)
        { }

        public IdParameter(IEnumerable<uint> ids)
            : base(ids)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.Select(id => id.ToString()));
        }
    }
}