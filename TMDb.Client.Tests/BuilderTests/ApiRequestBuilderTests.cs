using TMDb.Client.API.V3.Models.Discover;
using TMDb.Client.Builders;
using TMDb.Client.Enums;
using Xunit;

namespace TMDb.Client.Tests
{
    public class ApiRequestBuilderTests
    {
        private readonly RequestBuilder _requestBuilder;

        public ApiRequestBuilderTests()
        {
            _requestBuilder = new RequestBuilder();
        }

        [Fact]
        public void ApiRequestBuilder_ApiEndpoint_SmokeTest()
        {
            // Arrange
            var request = new DiscoverMovieRequest();

            // Act
            var endpoint = _requestBuilder.GetApiEndpoint(request);

            // Assert
            Assert.NotNull(endpoint.Path);
            Assert.NotNull(endpoint.HttpMethod);
        }

        [Fact]
        public void ApiRequestBuilder_ApiParameter_SmokeTest()
        {
            // Arrange
            var request = new DiscoverMovieRequest
            {
                SortBy = DiscoverMovieSortBy.PopularityDescending,
                IncludeAdult = false,
                IncludeVideo = false,
                Page = 10
            };

            request.SetBaseParameters();

            // Act
            var parameters = _requestBuilder.GetApiParameters(request);

            // Assert
            Assert.True(parameters.Count == 6);
        }
    }
}