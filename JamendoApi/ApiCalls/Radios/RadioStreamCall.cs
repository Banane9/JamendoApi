using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Radios;
using JamendoApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Radios
{
    /// <summary>
    /// Represents a call to the /radios/stream path.
    /// </summary>
    public sealed class RadioStreamCall : CallInformation<StreamRadio[]>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the id parameter.
        /// <para/>
        /// Only one Id is possible.
        /// </summary>
        public IdParameter Id { get; set; }

        /// <summary>
        /// Gets or sets the imagesize parameter.
        /// </summary>
        public ImageSizeParameter<RadioImageSize> ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the name parameter.
        /// </summary>
        public NameParameter Name { get; set; }

        /// <summary>
        /// Gets or sets the track_imagesize parameter.
        /// </summary>
        public TrackImageSizeParameter TrackImageSize { get; set; }

        /// <summary>
        /// Gets or sets the type parameter.
        /// </summary>
        public TypeParameter<RadioType> Type { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return Id;
                yield return ImageSize;
                yield return Name;
                yield return TrackImageSize;
                yield return Type;
            }
        }

        public override string Path
        {
            get { return "radios/stream"; }
        }
    }
}