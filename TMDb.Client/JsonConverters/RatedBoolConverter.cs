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
            t == typeof(TVEpisodeRatingBoolUnion) || t == typeof(TVEpisodeRatingBoolUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Boolean:
                    var boolValue = serializer.Deserialize<bool>(reader);
                    return new TVEpisodeRatingBoolUnion { Bool = boolValue };

                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<TVEpisodeRating>(reader);
                    return new TVEpisodeRatingBoolUnion { TVEpisodeRating = objectValue };

                default:
                    throw new Exception($"Cannot marshal type {nameof(TVEpisodeRatingBoolUnion)}");
            }
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (TVEpisodeRatingBoolUnion)@object;

            if (value.Bool != null)
            {
                serializer.Serialize(writer, value.Bool.Value);
            }
            else if (value.TVEpisodeRating != null)
            {
                serializer.Serialize(writer, value.TVEpisodeRating);
            }
            
            throw new Exception($"Cannot marshal type {nameof(TVEpisodeRatingBoolUnion)}");
        }
    }
}