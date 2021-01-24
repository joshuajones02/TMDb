using Newtonsoft.Json;
using System;
using TMDb.Client.Api.V3.Models.People;

namespace TMDb.Client.JsonConverters
{
    public class MovieTVCreditsCastConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static MovieTVCreditsCastConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(MovieTVCreditsCastUnion)}";

        public override bool CanConvert(Type t) =>
            t == typeof(MovieTVCreditsCastUnion) || t == typeof(MovieTVCreditsCastUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TryParseObject(serializer, out PeopleMovieCreditsCast movieCast))
            {
                return new MovieTVCreditsCastUnion { Movie = movieCast };
            }
            if (reader.TryParseObject(serializer, out PeopleTVCreditsCast tvCast))
            {
                return new MovieTVCreditsCastUnion { TV = tvCast };
            }

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (MovieTVCreditsCastUnion)@object;

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

        private static MovieTVCreditsCastConverter _instance;
        public static MovieTVCreditsCastConverter Instance => _instance ??= new MovieTVCreditsCastConverter();
    }
}