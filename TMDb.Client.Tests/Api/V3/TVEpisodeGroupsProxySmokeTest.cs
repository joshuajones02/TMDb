﻿using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVEpisodeGroups;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class TVEpisodeGroupsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.GameOfThrones)]
        public async Task TVEpisodeGroupsSmokeTest(int tvId)
        {
            var tvEpisodeGroups = await Client.TV.GetAsync(new Client.Api.V3.Models.TV.TVEpisodeGroupsRequest 
            { 
                TVId = tvId 
            });
            
            var response = await Client.TVEpisodeGroups.GetAsync(new TVEpisodeGroupsRequest
            { 
                Id = tvEpisodeGroups.Results.Single().Id 
            });

            Assert.True(response.GroupCount > 0);
            Assert.Equal(typeof(TVEpisodeGroupsResponse), response.GetType());
        }
    }
}