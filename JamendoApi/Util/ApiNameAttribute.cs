using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JamendoApi.Util
{
    internal static class OrderNameAttributeExtension
    {
        private static Dictionary<FieldInfo, string> names = new Dictionary<FieldInfo, string>();

        public static string GetName(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetRuntimeField(enumValue.ToString());

            if (!names.ContainsKey(fieldInfo))
            {
                var name = fieldInfo.GetCustomAttribute<ApiNameAttribute>(false)?.Name ?? enumValue.ToString();
                names.Add(fieldInfo, name);
            }

            return names[fieldInfo];
        }
    }

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