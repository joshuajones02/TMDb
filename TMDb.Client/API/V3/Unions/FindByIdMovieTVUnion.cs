namespace TMDb.Client.API.V3.Models.Find
{
    public struct FindByIdMovieTVUnion
    {
        public FindByIdMovieResult Movie;
        public FindByIdTVResult TV;

        public static implicit operator FindByIdMovieTVUnion(FindByIdMovieResult movie) =>
            new FindByIdMovieTVUnion 
            { 
                Movie = movie 
            };

        public static implicit operator FindByIdMovieTVUnion(FindByIdTVResult tv) =>
            new FindByIdMovieTVUnion 
            { 
                TV = tv
            };
    }
}