using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class AuthenticationProxy : ApiProxy
    {
        public AuthenticationProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<CreateGuestSessionResponse> GetAsync(CreateGuestSessionRequest request) =>
            Client.SendAsync<CreateGuestSessionResponse>(request);

        public virtual Task<CreateRequestTokenResponse> GetAsync(CreateRequestTokenRequest request) =>
            Client.SendAsync<CreateRequestTokenResponse>(request);

        public virtual Task<CreateSessionResponse> PostAsync(CreateSessionRequest request) =>
            Client.SendAsync<CreateSessionResponse>(request);

        public virtual Task<CreateSessionWithLoginResponse> PostAsync(CreateSessionWithLoginRequest request) =>
            Client.SendAsync<CreateSessionWithLoginResponse>(request);

        public virtual Task<DeleteSessionResponse> DeleteAsync(DeleteSessionRequest request) =>
            Client.SendAsync<DeleteSessionResponse>(request);
    }
}