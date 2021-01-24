using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using TMDb.Client.Constants;
using TMDb.Client.Models;

namespace TMDb.Client.Extensions
{
    public static class HttpRequestHeadersExtension
    {
        // TODO: Refactor ApiParamter parameter to Dictionary<string, string>
        public static void SetRequestHeaders(this HttpRequestHeaders headers, ApiParameter parameters)
        {
            if (parameters.Headers.Any())
            {
                foreach (var param in parameters.Headers)
                {
                    headers.Add(param.Key, param.Value);
                }
            }
            if (!headers.TryGetValues(CustomHeader.RequestId, out var _))
            {
                headers.Add(CustomHeader.RequestId, Guid.NewGuid().ToString());
            }
            foreach (var item in Trace.CorrelationManager.LogicalOperationStack.OfType<object>().Take(10))
            {
                headers.Add(CustomHeader.CorrelationId, item.ToString());
            }
        }
    }
}