using System;
using System.Net.Http;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public class HttpResponseResult
    {
        public int[] ExpectedStatusCodes { get; set; }
        public object ResponseData { get; set; }

        public TimeSpan Duration { get; set; }

        public ApiParameter[] Parameters { get; set; }
        public Exception Error { get; set; }
        public HttpRequestMessage Request { get; set; }
        public HttpResponseMessage Response { get; set; }
    }
}