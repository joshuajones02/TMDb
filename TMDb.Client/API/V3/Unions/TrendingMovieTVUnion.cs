using TMDb.Client.Api.V3.Models.Trending;

namespace TMDb.Client.Unions
{
    public struct TrendingMovieTVUnion
    {
        public TrendingMovie Movie { get; set; }
        public TrendingTV TV { get; set; }

        public static implicit operator TrendingMovieTVUnion(TrendingMovie movie) =>
            new TrendingMovieTVUnion
            {
                Movie = movie
            };

        public static implicit operator TrendingMovieTVUnion(TrendingTV tv) =>
            new TrendingMovieTVUnion
            {
                TV = tv
            };
    }
}