using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the audioformat parameter which is present in calls where the audo field is present.
    /// </summary>
    public sealed class AudioFormatParameter : Parameter<AudioFormatParameter, AudioFormatParameter.Format>
    {
        public override string Name
        {
            get { return "audioformat"; }
        }

        public AudioFormatParameter()
            : base(Format.Mp31)
        { }

        public AudioFormatParameter(Format size)
            : base(size)
        { }

        /// <summary>
        /// Lists the possible values for the size.
        /// </summary>
        public enum Format
        {
            /// <summary>
            /// MP3 with 96kbps.
            /// </summary>
            Mp31,

            /// <summary>
            /// MP3 with variable bitrate (good quality).
            /// </summary>
            Mp32,

            Ogg,

            Flac
        }
    }
}