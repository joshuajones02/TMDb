using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Authentication;
using TMDb.Client.Extensions;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class AuthenticationProxy : ApiProxy
    {
        public AuthenticationProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int id) => string.Format(path, id);

        public Task<CreateGuestSessionResponse> GetAsync(CreateGuestSessionRequest request) =>
            Client.GetAsync<CreateGuestSessionResponse>(
                Serialize("/authentication/guest_session/new", request));

        public Task<CreateGuestSessionResponse> GetAsync(CreateRequestTokenRequest request) =>
            Client.GetAsync<CreateGuestSessionResponse>(
                Serialize("/authentication/token/new", request));

        public Task<CreateSessionResponse> PostAsync(CreateSessionRequest request) =>
            Client.PostJsonAsync<CreateSessionResponse>(new UriBuilder(Client.BaseAddress)
            {
                Path = "/authentication/session/new"
            }.Uri, request.ToJson());

        public Task<CreateSessionWithLoginResponse> PostAsync(CreateSessionWithLoginRequest request) =>
            Client.PostJsonAsync<CreateSessionWithLoginResponse>(new UriBuilder(Client.BaseAddress)
            {
                Path = "/authentication/token/validate_with_login"
            }.Uri, request.ToJson());

        public Task<DeleteSessionResponse> DeleteAsync(DeleteSessionRequest request) =>
            Client.PostJsonAsync<DeleteSessionResponse>(new UriBuilder(Client.BaseAddress)
            {
                Path = "/authentication/session"
            }.Uri, request.ToJson());
    }
}