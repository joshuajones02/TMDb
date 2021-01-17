namespace TMDb.Client.API.V3.Models.Find
{
    public struct FindByIdMovieTVUnion
    {
        public FindByIdMovieResult Movie;
        public FindByIdTVResult TV;

        public static implicit operator FindByIdMovieTVUnion(FindByIdMovieResult Movie) =>
            new FindByIdMovieTVUnion 
            { 
                Movie = Movie 
            };

        public static implicit operator FindByIdMovieTVUnion(FindByIdTVResult TV) =>
            new FindByIdMovieTVUnion 
            { 
                TV = TV 
            };
    }
}