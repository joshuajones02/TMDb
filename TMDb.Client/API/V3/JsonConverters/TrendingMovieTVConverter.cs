using Newtonsoft.Json;
using System;
using TMDb.Client.Api.V3.Models.Trending;
using TMDb.Client.Unions;

namespace TMDb.Client.JsonConverters
{
    [Obsolete("// TODO: Not implemented with correct classes")]
    public class TrendingMovieTVConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static TrendingMovieTVConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(TrendingMovieTVUnion)}";

        public override bool CanConvert(Type t) =>
            t == typeof(TrendingMovieTVUnion) || t == typeof(TrendingMovieTVUnion?);

        // TODO: Needs refactoring, Make better when time is available
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TryParseObject(serializer, out TrendingMovie movie))
            {
                return new TrendingMovieTVUnion { Movie = movie };
            }
            if (reader.TryParseObject(serializer, out TrendingTV tv))
            {
                return new TrendingMovieTVUnion { TV = tv };
            }

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (TrendingMovieTVUnion)@object;

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

        private static TrendingMovieTVConverter _instance;
        public static TrendingMovieTVConverter Instance => _instance ??= new TrendingMovieTVConverter();
    }
}