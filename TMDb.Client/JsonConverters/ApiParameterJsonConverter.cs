using Newtonsoft.Json;
using System;

namespace TMDb.Client.JsonConverters
{
    internal class ApiParameterJsonConverter : JsonConverter
    {
        private static ApiParameterJsonConverter _instance;
        public static ApiParameterJsonConverter Instance =>
            _instance = _instance ?? new ApiParameterJsonConverter();

        public override bool CanConvert(Type t) => false;

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            return null;
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer) 
        { 
        }
    }
}