using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public class HttpResponseResult<TResponse> 
    {
        public int[] ExpectedStatusCodes { get; set; }

        public TimeSpan Duration => Timer.Elapsed;

        public List<ApiParameter> Parameters { get; set; }
        public Exception Exception { get; set; }
        public HttpRequestMessage Request { get; set; }
        public HttpResponseMessage Response { get; set; }
        public Stopwatch Timer { get; set; }

        public TResponse Result { get; set; }
    }
}