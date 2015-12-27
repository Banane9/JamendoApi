using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the imagesize parameter which is present in calls relating to albums, tracks and radios.
    /// </summary>
    public class ImageSizeParameter<TSize> : Parameter<ImageSizeParameter<TSize>, TSize>
    {
        public override string Name
        {
            get { return "imagesize"; }
        }

        public ImageSizeParameter()
            : base(default(TSize))
        { }

        public ImageSizeParameter(TSize size)
            : base(size)
        { }

        protected override string getValueString()
        {
            return ((Enum)(object)Value).GetName();
        }
    }

    /// <summary>
    /// Lists the possible values for the size of user avatars.
    /// </summary>
    public enum AvatarSize
    {
        Default,

        [ApiName("30")]
        Px30,

        [ApiName("50")]
        Px50,

        [ApiName("100")]
        Px100
    }

    /// <summary>
    /// Lists the possible values for the size of album/track covers.
    /// </summary>
    public enum CoverSize
    {
        [ApiName("")]
        Default,

        [ApiName("25")]
        Px25,

        [ApiName("35")]
        Px35,

        [ApiName("50")]
        Px50,

        [ApiName("55")]
        Px55,

        [ApiName("60")]
        Px60,

        [ApiName("65")]
        Px65,

        [ApiName("70")]
        Px70,

        [ApiName("75")]
        Px75,

        [ApiName("85")]
        Px85,

        [ApiName("1000")]
        Px1000,

        [ApiName("1300")]
        Px1300,

        [ApiName("1500")]
        Px1500,

        [ApiName("2000")]
        Px2000,

        [ApiName("3000")]
        Px3000,

        [ApiName("4000")]
        Px4000,

        [ApiName("5000")]
        Px5000,

        [ApiName("6000")]
        Px6000
    }

    /// <summary>
    /// Lists the possible values for the size of radio images.
    /// </summary>
    public enum RadioImageSize
    {
        [ApiName("")]
        Default,

        [ApiName("30")]
        Px30,

        [ApiName("150")]
        Px150
    }
}