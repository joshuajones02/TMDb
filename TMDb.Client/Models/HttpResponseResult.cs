using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;

namespace TMDb.Client
{
    public class HttpResponseResult<TResponse>
    {
        public int[] ExpectedStatusCodes { get; set; }

        public Exception Exception { get; set; }

        public HttpRequestMessage Request { get; set; }

        public HttpResponseMessage Response { get; set; }

        [JsonIgnore]
        public Stopwatch Timer { get; set; }

        public TimeSpan Duration => Timer.Elapsed;

        public TResponse Result { get; set; }
    }
}