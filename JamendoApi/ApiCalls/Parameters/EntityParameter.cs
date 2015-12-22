using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the entity parameter which is present in the autocomplete call.
    /// </summary>
    public sealed class EntityParameter : Parameter<EntityParameter, AutocompleteEntity>
    {
        public override string Name
        {
            get { return "entity"; }
        }

        public EntityParameter()
            : base(AutocompleteEntity.All)
        { }

        public EntityParameter(AutocompleteEntity entities)
            : base(entities)
        { }

        protected override string getValueString()
        {
            return string.Join("+", Value.GetFlagValues().Select(value => value.GetName()));
        }
    }
}