using System;
using System.Collections.Generic;
using System.Linq;

namespace TMDb.Client.Builders
{
    public class UrlBuilder
    {
        private readonly UriBuilder _uriBuilder;
        private Dictionary<string, string> _pathParameters;
        private Dictionary<string, string> _queryParameters;
        private string _path;

        public UrlBuilder(Uri uri) =>
            _uriBuilder = new UriBuilder(uri);

        public string Path
        {
            get => _path;
            set
            {
                if (_path.HasValue())
                {
                    throw new Exception($"Path has already been declared with {_path} cannot assign it {value}");
                }

                _path = value;
            }
        }

        public UrlBuilder AddQueryParameter(string name, string value)
        {
            if (_queryParameters == null)
            {
                _queryParameters = new Dictionary<string, string>();
            }

            _queryParameters.Add(name, value);

            return this;
        }

        public UrlBuilder AddPathParameter(string name, string value)
        {
            if (_pathParameters == null)
            {
                _pathParameters = new Dictionary<string, string>();
            }

            _pathParameters.Add(name, value);

            return this;
        }

        public Uri Uri
        {
            get
            {
                if (_queryParameters != null)
                {
                    var kvps = _queryParameters.Select(x => string.Format("{0}={1}", x.Key, x.Value));

                    _uriBuilder.Query = string.Join('&', kvps);
                }
                if (_pathParameters != null)
                {
                    foreach (var pathParam in _pathParameters)
                    {
                        if (_path.Contains(pathParam.Key))
                        {
                            var name = string.Format("{0}", pathParam.Key);
                            _path = _path.Replace(name, pathParam.Value);
                        }
                        else
                        {
                            var message = "The path '{0}' was expecting parameter '{1}'";

                            // TODO: Create custom exception
                            throw new Exception(string.Format(message, _path, pathParam.Key));
                        }
                    }
                }

                _uriBuilder.Path = _path;

                return _uriBuilder.Uri;
            }
        }

        public override string ToString() => Uri.ToString();
    }
}