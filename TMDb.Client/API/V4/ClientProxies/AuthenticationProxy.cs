//using System;
//using System.Threading.Tasks;
//using TMDb.Client.Api.V4.Models.Authentication;

//namespace TMDb.Client.Api.V4.ClientProxies
//{
//    public class AuthenticationProxy : ApiProxy
//    {
//        public AuthenticationProxy(TMDbClient client) : base(client)
//        {
//        }

//        public virtual string FormatPath(string path, int id) => string.Format(path, id);

//        public virtual Task<CreateSessionResponse> PostAsync(CreateSessionRequest request) =>
//            Client.PostJsonAsync<CreateSessionResponse>(new UriBuilder(Client.BaseAddress)
//            {
//                Path = "/authentication/session/convert/4"
//            }.Uri, request.ToJson());
//    }
//}