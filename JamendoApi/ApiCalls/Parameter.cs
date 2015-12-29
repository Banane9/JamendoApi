using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.ApiCalls
{
    /// <summary>
    /// Represents the generic base for all parameters.
    /// </summary>
    public abstract class Parameter<TParameter, TValue> : Parameter where TParameter : Parameter<TParameter, TValue>, new()
    {
        /// <summary>
        /// Gets the parameter's value.
        /// </summary>
        public TValue Value { get; set; }

        protected Parameter(TValue value)
        {
            Value = value;
        }

        public static implicit operator Parameter<TParameter, TValue>(TValue value)
        {
            var parameter = new TParameter();
            parameter.Value = value;

            return parameter;
        }

        public static implicit operator TParameter(Parameter<TParameter, TValue> parameter)
        {
            return (TParameter)parameter;
        }

        public static implicit operator TValue(Parameter<TParameter, TValue> parameter)
        {
            return parameter.Value;
        }

        protected override string getValueString()
        {
            return Value?.ToString() ?? "";
        }
    }

    /// <summary>
    /// Represents the abstract, non-generic base for all parameters.
    /// </summary>
    public abstract class Parameter
    {
        /// <summary>
        /// Gets the parameter's name.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Generates the parameter's parameter string.
        /// </summary>
        /// <returns>The parameter's parameter string.</returns>
        public string GetParameterString()
        {
            return $"{Name}={getValueString()}";
        }

        public override string ToString()
        {
            return GetParameterString();
        }

        protected abstract string getValueString();
    }
}