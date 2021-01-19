namespace TMDb.Client.API.V3.Models.Search
{
    public struct MultiSearchResultUnion
    {
        public MultiSearchMovieResult Movie;
        public MultiSearchTVResult TV;
        public MultiSearchPersonResult Person;

        public static implicit operator MultiSearchResultUnion(MultiSearchMovieResult movie) =>
            new MultiSearchResultUnion
            {
                Movie = movie
            };

        public static implicit operator MultiSearchResultUnion(MultiSearchTVResult tv) =>
            new MultiSearchResultUnion
            {
                TV = tv
            };

        public static implicit operator MultiSearchResultUnion(MultiSearchPersonResult person) =>
            new MultiSearchResultUnion
            {
                Person = person
            };
    }
}