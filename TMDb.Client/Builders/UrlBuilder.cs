using System;
using System.Collections.Generic;
using System.Linq;

namespace TMDb.Client.Builders
{
    public class UrlBuilder
    {
        private readonly UriBuilder _uriBuilder;

        public UrlBuilder(Uri baseUrl)
        {
            _uriBuilder = new UriBuilder(baseUrl);
        }

        public Dictionary<string, string> Query { get; set; }
        public Dictionary<string, string> PathParameters { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }

        public Uri Uri
        {
            get
            {
                if (Query != null)
                {
                    var serialized = Query.Select(x => string.Format("{0}={1}", x.Key, x.Value));
                    _uriBuilder.Query = string.Join('&', serialized);
                }
                if (Version.HasValue())
                {
                    Path = '/' + Version + Path;
                }
                if (PathParameters != null)
                {
                    foreach (var param in PathParameters)
                    {
                        if (!Path.Contains(param.Key))
                            throw new ArgumentException($"Parameter '{param.Key}' not found in path '{Path}'");

                        Path = Path.Replace($"{{{param.Key}}}", param.Value);
                    }
                }

                _uriBuilder.Path = Path;

                return _uriBuilder.Uri;
            }
        }

        public override string ToString() => Uri.ToString();
    }
}