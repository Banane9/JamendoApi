using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the relation parameter which is present in calls relating to users.
    /// </summary>
    /// <typeparam name="TRelation">The possible relations.</typeparam>
    public sealed class RelationParameter<TRelation> : Parameter<RelationParameter<TRelation>, TRelation>
    {
        public override string Name
        {
            get { return "relation"; }
        }

        public RelationParameter(TRelation relation)
            : base(relation)
        { }

        public RelationParameter()
            : base(default(TRelation))
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Cast<Enum>().Select(value => value.GetName()));
        }
    }
}