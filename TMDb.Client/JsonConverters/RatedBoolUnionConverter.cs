using Newtonsoft.Json;
using System;
using TMDb.Client.Models.Proxies.TVEpisodes;

namespace TMDb.Client.JsonConverters
{
    internal class RatedBoolUnionConverter : JsonConverter
    {
        private static RatedBoolUnionConverter _instance;
        public static RatedBoolUnionConverter Instance =>
            _instance = _instance ?? new RatedBoolUnionConverter();

        public override bool CanConvert(Type t) =>
            t == typeof(RatedUnion) || t == typeof(RatedUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new RatedUnion { Bool = boolValue };

                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<Rated>(reader);
                    return new RatedUnion { RatedClass = objectValue };

                default:
                    throw new Exception($"Cannot marshal type {nameof(RatedUnion)}");
            }
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (RatedUnion)@object;

            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
            }
            else if (value.RatedClass != null)
            {
                serializer.Serialize(writer, value.RatedClass);
            }
            else
            {
                throw new Exception($"Cannot marshal type {nameof(RatedUnion)}");
            }
        }
    }
}