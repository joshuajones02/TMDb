using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Configuration;
using Xunit;

namespace TMDb.Client.Tests
{
    public class TestsClient : IDisposable
    {
        public TestsClient()
        {
            Client = new TMDbClient(TestsSettings.Instance.ApiKey, TestsSettings.Instance.Version);
        }

        [Fact]
        public async Task TestApiKey()
        {
            var response = await Client.Configuration.GetConfigurationAsync();

            Assert.IsType<ConfigurationResponse>(response);
        }

        protected TMDbClient Client { get; private set; }

        public void Dispose()
        {
            if (Client != null)
            {
                Client = null;
            }
        }
    }
}