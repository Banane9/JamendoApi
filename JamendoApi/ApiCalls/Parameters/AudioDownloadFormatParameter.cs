using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the audiodlformat parameter which is present in calls where the audo field is present.
    /// </summary>
    public sealed class AudioDownloadFormatParameter : Parameter<AudioDownloadFormatParameter, AudioDownloadFormatParameter.Format>
    {
        public override string Name
        {
            get { return "audiodlformat"; }
        }

        public AudioDownloadFormatParameter()
            : base(Format.Mp32)
        { }

        public AudioDownloadFormatParameter(Format size)
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