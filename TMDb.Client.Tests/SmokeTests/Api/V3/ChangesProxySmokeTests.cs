using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Changes;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class ChangesProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task MovieChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new MovieChangeListRequest());

            Assert.IsType<ChangeListResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Fact]
        public async Task PersonChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new PersonChangeListRequest());

            Assert.IsType<ChangeListResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Fact]
        public async Task TVChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new TVChangeListRequest());

            Assert.IsType<ChangeListResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}