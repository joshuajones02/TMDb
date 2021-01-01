using TMDb.Client.Proxies;
using TMDb.Client.Settings;
using System;

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

            Settings = settings;
            Configuration = new ConfigurationProxy(this);
            Discover = new DiscoverProxy(this);
            Trending = new TrendingProxy(this);
            MovieClient = new TMDbMovieClient(this);
            TVClient = new TMDbTVClient(this);
        }

        internal ITMDbSettings Settings { get; }

        public ConfigurationProxy Configuration { get; }
        public DiscoverProxy Discover { get; private set; }
        public TrendingProxy Trending { get; }
        public TMDbMovieClient MovieClient { get; }
        public TMDbTVClient TVClient { get; }
    }
}