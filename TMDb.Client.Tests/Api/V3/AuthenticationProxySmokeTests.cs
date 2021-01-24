using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class AuthenticationProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task CreateGuestSessionSmokeTest()
        {
            var response = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());

            Assert.Equal(typeof(CreateGuestSessionResponse), response.GetType());
        }

        [Fact]
        public async Task CreateRequestTokenSmokeTest()
        {
            var response = await Client.Authentication.GetAsync(new CreateRequestTokenRequest());

            Assert.Equal(typeof(CreateRequestTokenResponse), response.GetType());
        }

        [Theory]
        [InlineData("")]
        public async Task CreateSessionSmokeTest(string requestToken)
        {
            throw new NotImplementedException("Need Request Token");

            var response = await Client.Authentication.PostAsync(new CreateSessionRequest 
            {
                RequestToken = requestToken
            });

            Assert.Equal(typeof(CreateSessionResponse), response.GetType());
        }

        [Theory]
        [InlineData("")]
        public async Task CreateSessionWithLoginSmokeTest(string requestToken)
        {
            throw new NotImplementedException("Need Request Token, username, and password");

            // TODO: Call to configuration appsettings.json
            var username = "";
            var password = "";

            var response = await Client.Authentication.PostAsync(new CreateSessionWithLoginRequest 
            {
                Username = username,
                Password = password,
                RequestToken = requestToken
            });

            Assert.Equal(typeof(CreateGuestSessionResponse), response.GetType());
        }

        [Theory]
        [InlineData("")]
        public async Task DeleteSessionSmokeTest(string sessionId)
        {
            throw new NotImplementedException("Need Session ID");

            var response = await Client.Authentication.DeleteAsync(new DeleteSessionRequest 
            {
                SessionId = sessionId
            });

            Assert.Equal(typeof(DeleteSessionResponse), response.GetType());
        }
    }
}