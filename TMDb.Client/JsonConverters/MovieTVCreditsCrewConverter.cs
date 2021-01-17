using Newtonsoft.Json;
using System;
using TMDb.Client.API.V3.Models.Find;

namespace TMDb.Client.JsonConverters
{
    [Obsolete("// TODO: Not implemented with correct classes")]
    public class MovieTVCreditsCrewConverter : JsonConverter
    {
        //private static MovieTVUnionConverter _instance;
        //public static MovieTVUnionConverter Instance =>
        //    _instance = _instance ?? new MovieTVUnionConverter();

        public override bool CanConvert(Type t) =>
            t == typeof(FindByIdMovieTVUnion) || t == typeof(FindByIdMovieTVUnion?);

        [Obsolete("// TODO: Needs refactoring, Make better when time is available")]
        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return new FindByIdMovieTVUnion
                {
                    Movie = serializer.Deserialize<FindByIdMovieResult>(reader)
                };
            }
            catch { }

            try
            {
                return new FindByIdMovieTVUnion
                {
                    TV = serializer.Deserialize<FindByIdTVResult>(reader)
                };
            }
            catch { }

            throw new Exception($"Cannot marshal type {nameof(FindByIdMovieTVUnion)}");
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
            else
            {
                throw new Exception($"Cannot marshal type {nameof(FindByIdMovieTVUnion)}");
            }
        }
    }
}