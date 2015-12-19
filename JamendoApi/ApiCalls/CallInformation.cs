﻿using System;
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
        /// <summary>
        /// Gets the not-null parameters.
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
        public string GetQueryString()
        {
            return Path + "?" + string.Join("&", Parameters.Select(parameter => parameter.GetParameterString()));
        }

        public override string ToString()
        {
            return GetQueryString();
        }
    }
}