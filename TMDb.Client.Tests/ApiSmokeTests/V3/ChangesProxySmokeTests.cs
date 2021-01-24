using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.Changes;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class ChangesProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task MovieChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new MovieChangeListRequest());

            Assert.Equal(typeof(ChangeListResponse), response.GetType());
        }

        [Fact]
        public async Task PersonChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new PersonChangeListRequest());

            Assert.Equal(typeof(ChangeListResponse), response.GetType());
        }

        [Fact]
        public async Task TVChangeListSmokeTest()
        {
            var response = await Client.Changes.GetAsync(new TVChangeListRequest());

            Assert.Equal(typeof(ChangeListResponse), response.GetType());
        }
    }
}