using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.Networks;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class NetworkProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData(0)]
        public async Task NetworkDetailsSmokeTest(int networkId)
        {
            throw new NotImplementedException("Need network ids or dynamically get them");
            var response = await Client.Network.GetAsync(new NetworkDetailsRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(NetworkDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData(0)]
        public async Task AlternativeNetworkNamesSmokeTest(int networkId)
        {
            throw new NotImplementedException("Need network ids or dynamically get them");
            var response = await Client.Network.GetAsync(new AlternativeNetworkNamesRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(AlternativeNetworkNamesResponse), response.GetType());
        }

        [Theory]
        [InlineData(0)]
        public async Task NetworkImagesSmokeTest(int networkId)
        {
            throw new NotImplementedException("Need network ids or dynamically get them");
            var response = await Client.Network.GetAsync(new NetworkImagesRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(NetworkImagesResponse), response.GetType());
        }
    }
}