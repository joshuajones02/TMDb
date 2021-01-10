using TMDb.Client.Proxies;

namespace TMDb.Client
{
    public class MovieClient
    {
        public MovieClient(TMDbClient client)
        {
            DiscoverMovies = new DiscoverMoviesProxy(client);
            Latest = new LatestMovieProxy(client);
            Movies = new MoviesProxy(client);
            SearchMovies = new SearchMoviesProxy(client);
        }

        public DiscoverMoviesProxy DiscoverMovies { get; }
        public LatestMovieProxy Latest { get; }
        public MoviesProxy Movies { get; }
        public SearchMoviesProxy SearchMovies{ get; }
    }
}