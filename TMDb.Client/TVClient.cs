using TMDb.Client.Proxies;

namespace TMDb.Client
{
    public class TVClient
    {
        public TVClient(TMDbClient client)
        {
            DiscoverTV = new DiscoverTVProxy(client);
            Search     = new SearchTVProxy(client);
            TV         = new TVProxy(client);
            TVSeasons  = new TVSeasonsProxy(client);
            TVEpisodes = new TVEpisodesProxy(client);
        }

        public DiscoverTVProxy DiscoverTV { get; }
        public SearchTVProxy Search { get; }
        public TVProxy TV { get; }
        public TVSeasonsProxy TVSeasons { get; }
        public TVEpisodesProxy TVEpisodes { get; }
    }
}