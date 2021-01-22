using System;
using TMDb.Client.API.V3.ClientProxies;
using TMDb.Client.Settings;

namespace TMDb.Client
{
    public class TMDbClient : HttpClientWrapper
    {
        public TMDbClient(string apiKey) : this(apiKey, "3")
        {
        }

        public TMDbClient(string apiKey, string version) : this(DefaultTMDbSettings.CreateInstance(apiKey), version)
        {
        }

        [Obsolete("// TODO: Implement lazy load pattern so each instance creation doesn't create every object instance for no reason")]
        public TMDbClient(ITMDbSettings settings, string version) : base(settings.BaseUrl)
        {
            if (settings.ApiKey.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(settings.ApiKey));

            Settings        = settings;
            Authentication  = new AuthenticationProxy(this);
            Certifications  = new CertificationsProxy(this);
            Changes         = new ChangesProxy(this);
            Collections     = new CollectionsProxy(this);
            Configuration   = new ConfigurationProxy(this);
            Credits         = new CreditsProxy(this);
            Discover        = new DiscoverProxy(this);
            Exports         = new ExportsProxy(this);
            Find            = new FindProxy(this);
            Genres          = new GenresProxy(this);
            GuestSessions   = new GuestSessionsProxy(this);
            Keywords        = new KeywordsProxy(this);
            Lists           = new ListsProxy(this);
            Movies          = new MoviesProxy(this);
            Network         = new NetworkProxy(this);
            People          = new PeopleProxy(this);
            Reviews         = new ReviewsProxy(this);
            Search          = new SearchProxy(this);
            Trending        = new TrendingProxy(this);
            TVEpisodeGroups = new TVEpisodeGroupsProxy(this);
            TVEpisodes      = new TVEpisodesProxy(this);
            TV              = new TVProxy(this);
            TVSeasons       = new TVSeasonsProxy(this);
        }

        internal ITMDbSettings Settings { get; }

        //public Lazy<AuthenticationProxy> AuthenticationLazy =>
        //      new Lazy<AuthenticationProxy>(() =>
        //              new AuthenticationProxy(this));

        public AuthenticationProxy Authentication { get; protected set; }
        public CertificationsProxy Certifications { get; protected set; }
        public ChangesProxy Changes { get; protected set; }
        public CollectionsProxy Collections { get; protected set; }
        public ConfigurationProxy Configuration { get; protected set; }
        public CreditsProxy Credits { get; protected set; }
        public DiscoverProxy Discover { get; protected set; }
        public ExportsProxy Exports { get; protected set; }
        public FindProxy Find { get; protected set; }
        public GenresProxy Genres { get; protected set; }
        public GuestSessionsProxy GuestSessions { get; protected set; }
        public KeywordsProxy Keywords { get; protected set; }
        public ListsProxy Lists { get; protected set; }
        public MoviesProxy Movies { get; protected set; }
        public NetworkProxy Network { get; protected set; }
        public PeopleProxy People { get; protected set; }
        public ReviewsProxy Reviews { get; protected set; }
        public SearchProxy Search { get; protected set; }
        public TrendingProxy Trending { get; protected set; }
        public TVEpisodeGroupsProxy TVEpisodeGroups { get; protected set; }
        public TVEpisodesProxy TVEpisodes { get; protected set; }
        public TVProxy TV { get; protected set; }
        public TVSeasonsProxy TVSeasons { get; protected set; }
    }
}