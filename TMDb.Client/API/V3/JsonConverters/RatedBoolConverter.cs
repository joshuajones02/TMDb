using Newtonsoft.Json;
using System;
using TMDb.Client.API.V3.Models.TVEpisodes;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.JsonConverters
{
    public class RatedBoolConverter : JsonConverter
    {
        private static RatedBoolConverter _instance;
        public static RatedBoolConverter Instance =>
            _instance = _instance ?? new RatedBoolConverter();

        public override bool CanConvert(Type t) =>
            t == typeof(TVRatingBoolUnion) || t == typeof(TVRatingBoolUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TVRatingBoolUnion { Bool = boolValue };

                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TVRating>(reader);
                    return new TVRatingBoolUnion { TVRating = objectValue };

                default:
                    throw new Exception($"Cannot marshal type {nameof(TVRatingBoolUnion)}");
            }
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (TVRatingBoolUnion)@object;

            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
            }
            else if (value.TVRating != null)
            {
                serializer.Serialize(writer, value.TVRating);
            }
            
            throw new Exception($"Cannot marshal type {nameof(TVRatingBoolUnion)}");
        }
    }
}