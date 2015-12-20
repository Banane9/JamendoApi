using JamendoApi.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls.Parameters
{
    /// <summary>
    /// Represents the order parameter which is present in nearly all calls.
    /// </summary>
    /// <typeparam name="TOptions">The enum that contains the possible options.</typeparam>
    public sealed class OrderParameter<TOptions> : Parameter<OrderParameter<TOptions>, TOptions>
    {
        /// <summary>
        /// Gets the sort order.
        /// </summary>
        public SortOrder Direction { get; set; }

        public override string Name
        {
            get { return "order"; }
        }

        public OrderParameter()
            : base(default(TOptions))
        { }

        public OrderParameter(TOptions order)
            : base(order)
        { }

        protected override string getValueString()
        {
            return ((Enum)(object)Value).GetName() + "_" + Direction.GetName();
        }
    }

    /// <summary>
    /// Lists the possible values for the sort order.
    /// </summary>
    public enum SortOrder
    {
        [ApiName("desc")]
        Descending,

        [ApiName("asc")]
        Ascending
    }
}