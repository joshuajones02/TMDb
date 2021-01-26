using TMDb.Client.Api;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public interface IApiParameterSerializer
    {
        ApiParameter SerializeRequestParameters(RequestBase request);
    }
}