using Newtonsoft.Json;
using System;
using TMDb.Client.API.V3.Models.People;

namespace TMDb.Client.JsonConverters
{
    public class MovieTVCreditsCrewConverter : JsonConverter
    {
        private static readonly string _exceptionMessage;

        static MovieTVCreditsCrewConverter() =>
            _exceptionMessage = $"Not able to marshal type {nameof(MovieTVCreditsCrewUnion)}";

        public override bool CanConvert(Type t) =>
            t == typeof(MovieTVCreditsCrewUnion) || t == typeof(MovieTVCreditsCrewUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TryParseObject(serializer, out PeopleMovieCreditsCrew movieCrew))
            {
                return new MovieTVCreditsCrewUnion { Movie = movieCrew };
            }
            if (reader.TryParseObject(serializer, out PeopleTVCreditsCrew tvCrew))
            {
                return new MovieTVCreditsCrewUnion { TV = tvCrew };
            }

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        {
            var value = (MovieTVCreditsCrewUnion)@object;

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

        private static MovieTVCreditsCrewConverter _instance;
        public static MovieTVCreditsCrewConverter Instance =>
            _instance = _instance ?? new MovieTVCreditsCrewConverter();
    }
}