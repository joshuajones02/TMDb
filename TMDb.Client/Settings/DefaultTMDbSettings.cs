using System;

namespace TMDb.Client.Settings
{
    public class DefaultTMDbSettings : ITMDbSettings
    {
        public string ApiKey { get; private set; }
        public string Version { get; private set; }
        public TimeSpan Timeout { get; private set; }
        public Uri BaseUrl { get; private set; }

        private DefaultTMDbSettings(string apiKey) =>
            ApiKey = apiKey;

        internal static DefaultTMDbSettings CreateInstance(string apiKey) =>
            _instance ??= new DefaultTMDbSettings(apiKey)
            {
                ApiKey  = apiKey,
                Version = "3",
                BaseUrl = new Uri("https://api.themoviedb.org"),
                Timeout = TimeSpan.FromMinutes(2)
            };

        private static DefaultTMDbSettings _instance;
        public static DefaultTMDbSettings Instance =>
            _instance = _instance ?? throw new NullReferenceException(nameof(Instance));
    }
}