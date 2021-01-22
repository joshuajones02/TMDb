using TMDb.Client.Api.V3.Models.Discover;
using TMDb.Client.Builders;
using TMDb.Client.Extensions;
using Xunit;

namespace TMDb.Client.Tests
{
    public class ApiRequestBuilderTests
    {
        private readonly IRequestBuilder _requestBuilder;

        public ApiRequestBuilderTests()
        {
            _requestBuilder = new RequestBuilder();
        }

        [Fact]
        public void RequestBuilder_ApiEndpoint_SmokeTest()
        {
            var endpoint = _requestBuilder.GetApiEndpoint(new DiscoverMovieRequest());

            // Assert
            Assert.NotNull(endpoint.Path);
            Assert.NotNull(endpoint.HttpMethod);
        }
    }
}