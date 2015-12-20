using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the imagesize parameter which is present in calls where the zip field is present.
    /// </summary>
    public sealed class ZipAudioformatParameter : Parameter<ZipAudioformatParameter, ZipAudioformatParameter.Size>
    {
        public override string Name
        {
            get { return "audioformat"; }
        }

        public ZipAudioformatParameter()
            : base(Size.Mp32)
        { }

        public ZipAudioformatParameter(Size size)
            : base(size)
        { }

        /// <summary>
        /// Lists the possible values for the size.
        /// </summary>
        public enum Size
        {
            /// <summary>
            /// MP3 with 192kbps.
            /// </summary>
            Mp32
        }
    }
}