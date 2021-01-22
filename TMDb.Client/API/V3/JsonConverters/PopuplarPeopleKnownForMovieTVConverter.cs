using Newtonsoft.Json;
using System;
using TMDb.Client.Api.V3.Models.People;
using TMDb.Client.Unions;

namespace TMDb.Client.JsonConverters
{
    public class PopularPeopleKnownForMovieTVConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static PopularPeopleKnownForMovieTVConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(PopularPeopleKnownForMovieTVUnion)}";

        public override bool CanConvert(Type t) =>
            t == typeof(PopularPeopleKnownForMovieTVUnion) || t == typeof(PopularPeopleKnownForMovieTVUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TryParseObject(serializer, out PersonKnownForMovie movieCrew))
            {
                return new PopularPeopleKnownForMovieTVUnion { Movie = movieCrew };
            }
            if (reader.TryParseObject(serializer, out PersonKnownForTV tvCrew))
            {
                return new PopularPeopleKnownForMovieTVUnion { TV = tvCrew };
            }

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (PopularPeopleKnownForMovieTVUnion)@object;

            if (value.Movie != null)
            {
                serializer.Serialize(writer, value.Movie);
            }
            else if (value.TV != null)
            {
                serializer.Serialize(writer, value.TV);
            }

            throw new Exception(_exceptionMessage);
        }

        private static PopularPeopleKnownForMovieTVConverter _instance;

        public static PopularPeopleKnownForMovieTVConverter Instance =>
            _instance = _instance ?? new PopularPeopleKnownForMovieTVConverter();
    }
}