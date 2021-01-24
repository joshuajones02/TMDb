using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Reviews;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class ReviewsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData("58aa82f09251416f92006a3a")]
        public async Task ReviewsSmokeTest(string reviewId)
        {
            var response = await Client.Reviews.GetAsync(new ReviewsRequest
            {
                ReviewId = reviewId
            });

            Assert.Equal(typeof(ReviewsResponse), response.GetType());
        }
    }
}