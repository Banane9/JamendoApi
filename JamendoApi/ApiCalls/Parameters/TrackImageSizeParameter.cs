using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the track_imagesize parameter which is present in calls relating to radios.
    /// </summary>
    public sealed class TrackImageSizeParameter : ImageSizeParameter<CoverSize>
    {
        public TrackImageSizeParameter()
            : base(CoverSize.Default)
        { }

        public TrackImageSizeParameter(CoverSize size)
            : base(size)
        { }
    }
}