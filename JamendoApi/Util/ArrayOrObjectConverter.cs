using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JamendoApi.Util
{
    internal sealed class ArrayOrObjectConverter : JsonConverter
    {
        public override bool CanWrite
        {
            get { return false; }
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<string, string>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            switch (token.Type)
            {
                case JTokenType.Array:
                    return new Dictionary<string, string>();

                case JTokenType.Object:
                    return token.ToObject<Dictionary<string, string>>();

                default:
                    throw new NotSupportedException("The fuck happened?");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}