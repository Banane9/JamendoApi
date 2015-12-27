using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the prolicensing parameter which is present in the tracks call.
    /// </summary>
    public sealed class ProLicensingParameter : Parameter<ProLicensingParameter, bool>
    {
        public override string Name
        {
            get { return "prolicensing"; }
        }

        public ProLicensingParameter()
            : base(false)
        { }

        public ProLicensingParameter(bool proLicensing)
            : base(proLicensing)
        { }

        protected override string getValueString()
        {
            return Value ? "true" : "";
        }
    }
}