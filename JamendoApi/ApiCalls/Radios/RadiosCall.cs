using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiEntities.Radios;
using JamendoApi.Common;
using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Radios
{
    /// <summary>
    /// Represents a call to the basic /radios path.
    /// </summary>
    public sealed class RadiosCall : CallInformation<BasicRadio[]>
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
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the name parameter.
        /// </summary>
        public NameParameter Name { get; set; }

        /// <summary>
        /// Gets or sets the offset parameter.
        /// </summary>
        public OffsetParameter Offset { get; set; }

        /// <summary>
        /// Gets or sets the order parameter.
        /// </summary>
        public OrderParameter<RadioOrder> Order { get; set; }

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
                yield return Limit;
                yield return Name;
                yield return Offset;
                yield return Order;
                yield return Type;
            }
        }

        public override string Path
        {
            get { return "/radios"; }
        }

        public enum RadioOrder
        {
            [ApiName("id")]
            Id,

            [ApiName("name")]
            Name,

            [ApiName("dispname")]
            DisplayName
        }
    }
}