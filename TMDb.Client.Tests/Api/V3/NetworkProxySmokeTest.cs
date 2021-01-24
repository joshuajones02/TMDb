using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Networks;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class NetworkProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData(   1)]     [InlineData(   2)]     [InlineData(   3)]     [InlineData(   4)]
        [InlineData(   5)]     [InlineData(   6)]     [InlineData(   8)]     [InlineData(   9)]
        [InlineData(  10)]     [InlineData(  11)]     [InlineData(  12)]     [InlineData(  13)]
        [InlineData(  14)]     [InlineData(  15)]     [InlineData(  16)]     [InlineData(  17)]
        [InlineData(  18)]     [InlineData(  19)]     [InlineData(1011)]     [InlineData(1012)]
        [InlineData(1013)]     [InlineData(1014)]     [InlineData(1015)]     [InlineData(1016)]
        [InlineData(1017)]     [InlineData(1018)]     [InlineData(1019)]     [InlineData(2732)]
        [InlineData(2733)]     [InlineData(2734)]     [InlineData(2735)]     [InlineData(2736)]
        [InlineData(2737)]     [InlineData(2739)]     [InlineData(4100)]     [InlineData(4101)]
        [InlineData(4103)]     [InlineData(4105)]     [InlineData(4106)]
        public async Task NetworkDetailsSmokeTest(int networkId)
        {
            var response = await Client.Network.GetAsync(new NetworkDetailsRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(NetworkDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData(   1)]     [InlineData(   2)]     [InlineData(   3)]     [InlineData(   4)]
        [InlineData(   5)]     [InlineData(   6)]     [InlineData(   8)]     [InlineData(   9)]
        [InlineData(  10)]     [InlineData(  11)]     [InlineData(  12)]     [InlineData(  13)]
        [InlineData(  14)]     [InlineData(  15)]     [InlineData(  16)]     [InlineData(  17)]
        [InlineData(  18)]     [InlineData(  19)]     [InlineData(1011)]     [InlineData(1012)]
        [InlineData(1013)]     [InlineData(1014)]     [InlineData(1015)]     [InlineData(1016)]
        [InlineData(1017)]     [InlineData(1018)]     [InlineData(1019)]     [InlineData(2732)]
        [InlineData(2733)]     [InlineData(2734)]     [InlineData(2735)]     [InlineData(2736)]
        [InlineData(2737)]     [InlineData(2739)]     [InlineData(4100)]     [InlineData(4101)]
        [InlineData(4103)]     [InlineData(4105)]     [InlineData(4106)]
        public async Task AlternativeNetworkNamesSmokeTest(int networkId)
        {
            var response = await Client.Network.GetAsync(new AlternativeNetworkNamesRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(AlternativeNetworkNamesResponse), response.GetType());
        }

        [Theory]
        [InlineData(   1)]     [InlineData(   2)]     [InlineData(   3)]     [InlineData(   4)]
        [InlineData(   5)]     [InlineData(   6)]     [InlineData(   8)]     [InlineData(   9)]
        [InlineData(  10)]     [InlineData(  11)]     [InlineData(  12)]     [InlineData(  13)]
        [InlineData(  14)]     [InlineData(  15)]     [InlineData(  16)]     [InlineData(  17)]
        [InlineData(  18)]     [InlineData(  19)]     [InlineData(1011)]     [InlineData(1012)]
        [InlineData(1013)]     [InlineData(1014)]     [InlineData(1015)]     [InlineData(1016)]
        [InlineData(1017)]     [InlineData(1018)]     [InlineData(1019)]     [InlineData(2732)]
        [InlineData(2733)]     [InlineData(2734)]     [InlineData(2735)]     [InlineData(2736)]
        [InlineData(2737)]     [InlineData(2739)]     [InlineData(4100)]     [InlineData(4101)]
        [InlineData(4103)]     [InlineData(4105)]     [InlineData(4106)]
        public async Task NetworkImagesSmokeTest(int networkId)
        {
            var response = await Client.Network.GetAsync(new NetworkImagesRequest
            {
                NetworkId = networkId
            });

            Assert.Equal(typeof(NetworkImagesResponse), response.GetType());
        }
    }
}