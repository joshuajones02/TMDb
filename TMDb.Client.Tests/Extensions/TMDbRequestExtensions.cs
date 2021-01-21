using TMDb.Client.API.V3.Models;

namespace TMDb.Client.Tests
{
    public static class TMDbRequestExtensions
    {
        private readonly static TestsSettings _settings;

        static TMDbRequestExtensions()
        {
            _settings = TestsSettings.Instance;
        }

        public static void SetBaseParameters<TTMDbRequest>(this TTMDbRequest tmdbRequest) where TTMDbRequest : TMDbRequest
        {
            tmdbRequest.ApiKey = _settings.ApiKey;
            tmdbRequest.Version = _settings.Version;
        }
    }
}