using System;
using TMDb.Client.Proxies;
using TMDb.Client.Settings;

namespace TMDb.Client
{
    public class TMDbClient : RestClient
    {
        public TMDbClient(string apiKey)
            : this(DefaultTMDbSettings.CreateInstance(apiKey))
        {
        }

        public TMDbClient(ITMDbSettings settings)
            : base(settings.BaseUrl)
        {
            if (settings.ApiKey.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(settings.ApiKey));

            Settings      = settings;
            Configuration = new ConfigurationProxy(this);
            Discover      = new DiscoverProxy(this);
            Movies        = new MoviesProxy(this);
            Trending      = new TrendingProxy(this);
            TV            = new TVProxy(this);
            TVSeasons     = new TVSeasonsProxy(this);
            TVEpisodes    = new TVEpisodesProxy(this);
        }

        internal ITMDbSettings Settings { get; }

        public ConfigurationProxy Configuration { get; protected set; }
        public DiscoverProxy Discover { get; protected set; }
        public MoviesProxy Movies { get; protected set; }
        public TrendingProxy Trending { get; protected set; }
        public TVProxy TV { get; protected set; }
        public TVSeasonsProxy TVSeasons { get; protected set; }
        public TVEpisodesProxy TVEpisodes { get; protected set; }
    }
}