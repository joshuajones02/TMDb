using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVEpisodeGroups;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class TVEpisodeGroupsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData("")]
        public async Task TVEpisodeGroupsSmokeTest(string id)
        {
            throw new NotImplementedException("Need id");
            var response = await Client.TVEpisodeGroups.GetAsync(new TVEpisodeGroupsRequest
            {
                Id = id
            });

            Assert.True(response.GroupCount > 0);
            Assert.Equal(typeof(TVEpisodeGroupsResponse), response.GetType());
        }
    }
}