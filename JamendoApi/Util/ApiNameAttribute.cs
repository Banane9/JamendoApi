using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Util
{
    /// <summary>
    /// Put on the fields of enums to specify the name in the API.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    internal sealed class ApiNameAttribute : Attribute
    {
        private readonly string name;

        /// <summary>
        /// Gets the enum field's API name.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ApiNameAttribute"/> class with the given name.
        /// </summary>
        /// <param name="name">The enum field's API name.</param>
        public ApiNameAttribute(string name)
        {
            this.name = name;
        }
    }
}