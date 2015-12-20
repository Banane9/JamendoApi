using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the audioformat parameter which is present in calls where the zip field is present.
    /// </summary>
    public sealed class ZipAudioFormatParameter : Parameter<ZipAudioFormatParameter, ZipAudioFormatParameter.Format>
    {
        public override string Name
        {
            get { return "audioformat"; }
        }

        public ZipAudioFormatParameter()
            : base(Format.Mp32)
        { }

        public ZipAudioFormatParameter(Format size)
            : base(size)
        { }

        /// <summary>
        /// Lists the possible values for the size.
        /// </summary>
        public enum Format
        {
            /// <summary>
            /// MP3 with 192kbps.
            /// </summary>
            Mp32
        }
    }
}