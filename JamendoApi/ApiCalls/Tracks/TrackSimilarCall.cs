using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Tracks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Tracks
{
    /// <summary>
    /// Represents a call to the /tracks/similar path.
    /// </summary>
    public sealed class TrackSimilarCall : CallInformation<SimilarTrack[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the audiodlformat parameter.
        /// </summary>
        public AudioDownloadFormatParameter AudioDownloadFormat { get; set; }

        /// <summary>
        /// Gets or sets the aduioformat parameter.
        /// </summary>
        public AudioFormatParameter AudioFormat { get; set; }

        /// <summary>
        /// Gets or sets the id parameter.
        /// </summary>
        public IdParameter Ids { get; set; }

        /// <summary>
        /// Gets or sets the imagesize parameter.
        /// </summary>
        public ImageSizeParameter<CoverSize> ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the include parameter.
        /// </summary>
        public IncludeParameter Include { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the no_album parameter.
        /// </summary>
        public NoAlbumParameter NoAlbum { get; set; }

        /// <summary>
        /// Gets or sets the no_artist parameter.
        /// </summary>
        public NoArtistParameter NoArtist { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return AudioDownloadFormat;
                yield return AudioFormat;
                yield return Ids;
                yield return ImageSize;
                yield return Include;
                yield return Limit;
                yield return NoAlbum;
                yield return NoArtist;
                yield return Offset;
            }
        }

        public override string Path
        {
            get { return "/tracks/similar"; }
        }
    }
}