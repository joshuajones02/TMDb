using Newtonsoft.Json;
using System;
using TMDb.Client.Api.V3.Models.Find;

namespace TMDb.Client.JsonConverters
{
    internal class MovieTVUnionConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static MovieTVUnionConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(FindByIdMovieTVUnion)}";

        public override bool CanConvert(Type t) =>
            t == typeof(FindByIdMovieTVUnion) || t == typeof(FindByIdMovieTVUnion?);

        // TODO: Needs refactoring, Make better when time is available
        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TryParseObject(serializer, out FindByIdMovieResult movieCrew))
            {
                return new FindByIdMovieTVUnion { Movie = movieCrew };
            }
            if (reader.TryParseObject(serializer, out FindByIdTVResult tvCrew))
            {
                return new FindByIdMovieTVUnion { TV = tvCrew };
            }

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (FindByIdMovieTVUnion)@object;

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

        private static MovieTVUnionConverter _instance;
        public static MovieTVUnionConverter Instance => _instance ??= new MovieTVUnionConverter();
    }
}