using Newtonsoft.Json;
using System;
using TMDb.Client.Api.V3.Models.Trending;
using TMDb.Client.Enums;
using TMDb.Client.Unions;

namespace TMDb.Client.JsonConverters
{
    public class TrendingMovieTVConverter : JsonConverter
    {
        private static readonly string _exceptionMessage = $"Not able to marshal type {nameof(TrendingMovieTVPersonUnion)}";

        public override bool CanRead => true;
        public override bool CanWrite => false;
        public override bool CanConvert(Type t) =>
            t == typeof(TrendingMovieTVPersonUnion) || t == typeof(TrendingMovieTVPersonUnion?);

        public class TrendingType
        {
            public MediaType MediaType { get; set; }
        }

        // TODO: Needs refactoring, Make better when time is available
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                var test = reader.Value as string;
                var test2 = (string)reader.Value;

                if (test2 == null)
                    return null;
                    //return new TrendingMovieTVPersonUnion(); 

                var type = JsonConvert.DeserializeObject<TrendingType>(test).MediaType;

                switch (type)
                {
                    case MediaType.Movie:
                        return new TrendingMovieTVPersonUnion { Movie = serializer.Deserialize<TrendingMovie>(reader) };
                    case MediaType.Person:
                        return new TrendingMovieTVPersonUnion { Person = serializer.Deserialize<TrendingPerson>(reader) };
                    case MediaType.TV:
                        return new TrendingMovieTVPersonUnion { TV = serializer.Deserialize<TrendingTV>(reader) };
                    default:
                        throw new NotSupportedException(type.ToString());
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.TraceInformation(ex.Minify().ToJson());
            }

            //if (reader.TryParseObject(serializer, out TrendingMovie movie))
            //{
            //    return new TrendingMovieTVUnion { Movie = movie };
            //}
            //if (reader.TryParseObject(serializer, out TrendingTV tv))
            //{
            //    return new TrendingMovieTVUnion { TV = tv };
            //}

            throw new Exception(_exceptionMessage);
        }

        public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer) => 
            throw new NotImplementedException();

        //public override void WriteJson(JsonWriter writer, object @object, JsonSerializer serializer)
        //{
        //    var value = (TrendingMovieTVUnion)@object;

        //    if (value.Movie != null)
        //    {
        //        serializer.Serialize(writer, value.Movie);
        //    }
        //    else if (value.TV != null)
        //    {
        //        serializer.Serialize(writer, value.TV);
        //    }

        //    throw new Exception(_exceptionMessage);
        //}

        private static TrendingMovieTVConverter _instance;
        public static TrendingMovieTVConverter Instance => 
            _instance = _instance ?? new TrendingMovieTVConverter();
    }
}