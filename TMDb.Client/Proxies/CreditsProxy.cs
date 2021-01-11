using System;
using System.Threading.Tasks;
using TMDb.Client.Models;
using TMDb.Client.Models.Proxies.Credits;

namespace TMDb.Client.Proxies
{
    public class CreditsProxy : ProxyBase
    {
        private static readonly string _path;
        private static readonly TMDbRequest _request;

        static CreditsProxy()
        {
            _path = "/credit/{0}";
            _request = new TMDbRequest();
        }

        public CreditsProxy(TMDbClient client) : base(client)
        {
        }

        public Task<CreditsResponse> Get(string creditId) =>
            Client.GetAsync<CreditsResponse>(
                FormatPathAndSerialize(creditId));

        private Uri FormatPathAndSerialize(string creditId) =>
            Serialize(string.Format(_path, creditId), _request);
    }
}