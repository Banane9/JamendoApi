using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the boost parameter which is present in the tracks call.
    /// </summary>
    public sealed class BoostParameter : Parameter<BoostParameter, BoostParameter.Boost>
    {
        public override string Name
        {
            get { return "boost"; }
        }

        public BoostParameter()
            : base(Boost.Default)
        { }

        public BoostParameter(Boost boost)
            : base(boost)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }

        public enum Boost
        {
            Default,

            [ApiName("buzzrate")]
            Buzzrate,

            [ApiName("downloads_week")]
            DownloadsWeek,

            [ApiName("downloads_month")]
            DownloadsMonth,

            [ApiName("downloads_total")]
            DownloadsTotal,

            [ApiName("listens_week")]
            ListensWeek,

            [ApiName("listens_month")]
            ListensMonth,

            [ApiName("listens_total")]
            ListensTotal,

            [ApiName("popularity_week")]
            PopularityWeek,

            [ApiName("popularity_month")]
            PopularityMonth,

            [ApiName("popularity_total")]
            PopularityTotal
        }
    }
}