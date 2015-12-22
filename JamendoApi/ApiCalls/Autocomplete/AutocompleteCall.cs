using JamendoApi.ApiCalls.Parameters;
using JamendoApi.ApiParts.Autocomplete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Autocomplete
{
    /// <summary>
    /// Represents a call to the basic /autocomplete path.
    /// </summary>
    public sealed class AutocompleteCall : CallInformation<Matches>
    {
        #region Parameters

        /// <summary>
        /// Gets or sets the entity parameter.
        /// </summary>
        public EntityParameter Entity { get; set; }

        /// <summary>
        /// Gets or sets the limit parameter.
        /// </summary>
        public LimitParameter Limit { get; set; }

        /// <summary>
        /// Gets or sets the matchcount parameter.
        /// </summary>
        public MatchcountParameter Matchcount { get; } = new MatchcountParameter(true);

        /// <summary>
        /// Gets or sets the prefix parameter.
        /// </summary>
        public PrefixParameter Prefix { get; set; }

        #endregion Parameters

        public override IEnumerable<Parameter> Parameters
        {
            get
            {
                yield return Entity;
                yield return Limit;
                yield return Matchcount;
                yield return Prefix;
            }
        }

        public override string Path
        {
            get { return "/autocomplete"; }
        }

        public AutocompleteCall(PrefixParameter prefix)
        {
            Prefix = prefix;
        }
    }
}