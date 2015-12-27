using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the groupby parameter which is present in the tracks call.
    /// </summary>
    public sealed class GroupByParameter : Parameter<GroupByParameter, GroupByParameter.GroupBy>
    {
        public override string Name
        {
            get { return "groupby"; }
        }

        public GroupByParameter()
            : base(GroupBy.Default)
        { }

        public GroupByParameter(GroupBy groupBy)
            : base(groupBy)
        { }

        protected override string getValueString()
        {
            return Value.GetName();
        }

        public enum GroupBy
        {
            Default,

            [ApiName("artist_id")]
            ArtistId,

            [ApiName("album_id")]
            AlbumId
        }
    }
}