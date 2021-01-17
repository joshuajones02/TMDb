using Newtonsoft.Json;
using System;
using TMDb.Client.API.V3.Models.TVEpisodes;

namespace TMDb.Client.JsonConverters
{
    public class RatedBoolUnionConverter : JsonConverter
    {
        private static RatedBoolUnionConverter _instance;
        public static RatedBoolUnionConverter Instance =>
            _instance = _instance ?? new RatedBoolUnionConverter();

        public override bool CanConvert(Type t) =>
            t == typeof(TVEpisodesBoolRateValueUnion) || t == typeof(TVEpisodesBoolRateValueUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TVEpisodesBoolRateValueUnion { Bool = boolValue };

                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<RateValue>(reader);
                    return new TVEpisodesBoolRateValueUnion { Rated = objectValue };

                default:
                    throw new Exception($"Cannot marshal type {nameof(TVEpisodesBoolRateValueUnion)}");
            }
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (TVEpisodesBoolRateValueUnion)@object;

            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
            }
            else if (value.Rated != null)
            {
                serializer.Serialize(writer, value.Rated);
            }
            else
            {
                throw new Exception($"Cannot marshal type {nameof(TVEpisodesBoolRateValueUnion)}");
            }
        }
    }
}