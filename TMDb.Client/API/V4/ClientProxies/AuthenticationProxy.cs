using System;
using System.Threading.Tasks;
using TMDb.Client.API.V4.Models.Authentication;
using TMDb.Client.Extensions;

namespace TMDb.Client.API.V4.ClientProxies
{
    public class AuthenticationProxy : ApiProxy
    {
        public AuthenticationProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int id) => string.Format(path, id);

        public Task<CreateSessionResponse> PostAsync(CreateSessionRequest request) =>
            Client.PostJsonAsync<CreateSessionResponse>(new UriBuilder(Client.BaseAddress)
            {
                Path = "/authentication/session/convert/4"
            }.Uri, request.ToJson());
    }
}