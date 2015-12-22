using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace JamendoApi.Util
{
    internal static class EnumExtensions
    {
        private static Dictionary<FieldInfo, string> names = new Dictionary<FieldInfo, string>();

        public static IEnumerable<TEnum> GetFlagValues<TEnum>(this TEnum enumValue)
        {
            var enumValues = Enum.GetValues(typeof(TEnum)).Cast<int>();
            var origValue = (int)(object)enumValue;

            return enumValues.Where(value => (origValue & value) > 0).Cast<TEnum>();
        }

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
}