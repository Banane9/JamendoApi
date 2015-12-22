using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the lang parameter which is present in the feeds call.
    /// </summary>
    public sealed class LanguageParameter : Parameter<LanguageParameter, Language>
    {
        public override string Name
        {
            get { return "lang"; }
        }

        public LanguageParameter()
            : base(Language.English)
        { }

        public LanguageParameter(Language language)
            : base(language)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}