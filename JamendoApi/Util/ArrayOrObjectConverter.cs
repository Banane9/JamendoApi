using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Util
{
    internal sealed class ArrayOrObjectConverter<TTarget> : JsonConverter
    {
        private static readonly object[] arrayParameters = new object[] { 0 };
        private static readonly Type targetType = typeof(TTarget);

        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == targetType;
        }

        public TTarget GetObject(JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Array:
                    if (targetType.IsArray)
                        return token.ToObject<TTarget>();

                    // For the edge case of the autocomplete method returning an empty array instead of
                    // the usual object when no matches are found.
                    return Activator.CreateInstance<TTarget>();

                case JTokenType.Object:
                    return token.ToObject<TTarget>();

                default:
                    throw new NotSupportedException("The json was malformed.");
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return GetObject(JToken.Load(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}