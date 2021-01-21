using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using TMDb.Client.Attributes;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public class RequestBuilder : IRequestBuilder
    {
        [Obsolete("// TODO: Is 'string path' needed if RestParameter has ApiEndpoint value?")]
        public HttpRequestMessage BuildRequest(Uri baseAddress, ApiEndpoint endpoint, List<ApiParameter> parameters, IRestClientConfiguration config)
        {
            var pathParameters = new Dictionary<string, string>();
            var queryParameters = new Dictionary<string, string>();
            var uriBuilder = new UrlBuilder(baseAddress);
            var request = new HttpRequestMessage { Method = endpoint.HttpMethod };

            foreach (var param in parameters.Where(x => x.Value != null))
            {
                if (param.ParameterType == ParameterType.NotSet)
                {
                    throw new ArgumentOutOfRangeException($"ParameterType must be set for {param.Name}");
                }
                else if (param.ParameterType == ParameterType.Header && param.Value.HasValue())
                {
                    request.Headers.Add(param.Name, param.Value);
                }
                // TODO: Refactor this to allow parameters to be added
                else if (param.ParameterType == ParameterType.JsonBody && param.Value.HasValue())
                {
                    if (request.Content != null)
                        throw new ArgumentException("Only one JSON body can be specified as a Body parameter.");

                    var contentType = !request.Headers.Contains(ContentType.Name) ? ContentType.Json : null;
                    request.Content = new StringContent(param.Value.ToJson(), Encoding.UTF8, contentType);
                }
                else if (param.ParameterType == ParameterType.PathPrepend && param.Value.HasValue())
                {
                    // TODO: *** Move to UriBuilder
                    if (!param.Value.StartsWith('/'))
                        param.Value = "/" + param.Value;
                    if (param.Value.EndsWith('/'))
                        param.Value = param.Value.Remove(param.Value.Length - 1, 1);
                    if (!endpoint.Path.StartsWith('/'))
                        endpoint.Path = "/" + endpoint.Path;

                    endpoint.Path = param.Value + endpoint.Path;
                }
                else if (param.ParameterType == ParameterType.Path)
                {
                    pathParameters.Add(param.Name, param.Value);
                }
                else if (param.ParameterType == ParameterType.Query)
                {
                    queryParameters.Add(param.Name, param.Value);
                }
            }



            // TODO: Make it more clear in code here that UriBuilder will update the path
            uriBuilder.Path = endpoint.Path;
            request.RequestUri = uriBuilder.Uri;

            if (!request.Headers.TryGetValues(CustomHeader.RequestId, out var _))
            {
                request.Headers.Add(CustomHeader.RequestId, Guid.NewGuid().ToString());
            }
            foreach (var item in System.Diagnostics.Trace.CorrelationManager.LogicalOperationStack.OfType<object>().Take(10))
            {
                request.Headers.Add(CustomHeader.CorrelationId, item.ToString());
            }

            return request;
        }
    }
}