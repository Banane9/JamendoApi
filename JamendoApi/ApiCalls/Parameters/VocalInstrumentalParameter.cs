using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the vocalinstrumental parameter which is present in the tracks call.
    /// </summary>
    public sealed class VocalInstrumentalParameter : Parameter<VocalInstrumentalParameter, VocalInstrumental>
    {
        public override string Name
        {
            get { return "vocalinstrumental"; }
        }

        public VocalInstrumentalParameter()
            : base(VocalInstrumental.Default)
        { }

        public VocalInstrumentalParameter(VocalInstrumental vocalInstrumental)
            : base(vocalInstrumental)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }
    }
}