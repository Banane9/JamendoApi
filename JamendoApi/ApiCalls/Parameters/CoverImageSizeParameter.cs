using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the imagesize parameter which is present in calls relating to albums and tracks.
    /// </summary>
    public sealed class CoverImageSizeParameter : Parameter<CoverImageSizeParameter, CoverImageSizeParameter.Size>
    {
        public override string Name
        {
            get { return "imagesize"; }
        }

        public CoverImageSizeParameter()
            : base(Size.Px200)
        { }

        public CoverImageSizeParameter(Size size)
            : base(size)
        { }

        protected override string getValueString()
        {
            return ((uint)Value).ToString();
        }

        /// <summary>
        /// Lists the possible values for the size.
        /// </summary>
        public enum Size
        {
            Px25 = 25,
            Px35 = 35,
            Px50 = 50,
            Px55 = 55,
            Px60 = 60,
            Px65 = 65,
            Px70 = 70,
            Px75 = 75,
            Px85 = 85,
            Px100 = 100,
            Px130 = 130,
            Px150 = 150,
            Px200 = 200,
            Px300 = 300,
            Px400 = 400,
            Px500 = 500,
            Px600 = 600
        }
    }
}