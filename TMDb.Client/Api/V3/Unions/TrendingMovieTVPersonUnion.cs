using TMDb.Client.Api.V3.Models.Trending;

namespace TMDb.Client.Unions
{
    public struct TrendingMovieTVPersonUnion
    {
        public TrendingMovie Movie { get; set; }
        public TrendingTV TV { get; set; }
        public TrendingPerson Person { get; set; }

        public static implicit operator TrendingMovieTVPersonUnion(TrendingMovie movie) =>
            new TrendingMovieTVPersonUnion
            {
                Movie = movie
            };

        public static implicit operator TrendingMovieTVPersonUnion(TrendingTV tv) =>
            new TrendingMovieTVPersonUnion
            {
                TV = tv
            };
        public static implicit operator TrendingMovieTVPersonUnion(TrendingPerson person) =>
            new TrendingMovieTVPersonUnion
            {
                Person = person
            };
    }
}