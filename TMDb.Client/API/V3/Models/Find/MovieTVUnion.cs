namespace TMDb.Client.API.V3.Models.Find
{
    public struct MovieTVUnion
    {
        public FindByIdMovieResult Movie;
        public FindByIdTVResult TV;

        public static implicit operator MovieTVUnion(FindByIdMovieResult Movie) =>
            new MovieTVUnion { Movie = Movie };

        public static implicit operator MovieTVUnion(FindByIdTVResult TV) =>
            new MovieTVUnion { TV = TV };
    }
}