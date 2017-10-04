using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls
{
    /// <summary>
    /// Represents the abstract base for all calls.
    /// </summary>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    public abstract class CallInformation<TResult>
    {
        private const string format = "json";

        /// <summary>
        /// Gets all parameters that aren't null.
        /// </summary>
        public IEnumerable<Parameter> NonNullParameters
        {
            get { return Parameters.Where(p => p != null); }
        }

        /// <summary>
        /// Gets all parameters.
        /// </summary>
        public abstract IEnumerable<Parameter> Parameters { get; }

        /// <summary>
        /// Gets the path of the call.
        /// </summary>
        public abstract string Path { get; }

        /// <summary>
        /// Generates the call's query string.
        /// </summary>
        /// <returns>The query string for the call.</returns>
        public string GetQueryString(string clientId)
        {
            return $@"{Path}?client_id={clientId}&format={format}&{string.Join("&",
                NonNullParameters.Select(parameter => parameter.GetParameterString()))}";
        }

        public override string ToString()
        {
            return $@"{Path}?{string.Join("&",
                NonNullParameters.Select(parameter => parameter.GetParameterString()))}";
        }
    }
}