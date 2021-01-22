using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using TMDb.Client.API;
using TMDb.Client.Attributes;
using TMDb.Client.Builders;
using TMDb.Client.Models;

namespace TMDb.Client.Extensions
{
    public static class IRequestBuilderApiParameterExtensions
    {
        public static ApiParameter GetApiParameters(this IRequestBuilder builder, RequestBase request)
        {
            var headers = new Dictionary<string, string>();
            var query   = new Dictionary<string, string>();
            var path    = new Dictionary<string, string>();
            var body    = new Dictionary<string, string>();
            var version = default(string);

            var props = request.GetType()
                .GetProperties()
                //.Where(x => x.HasAttribute<ApiParameterAttribute>()));
                .Where(x => Attribute.IsDefined(x, typeof(ApiParameterAttribute)));

            foreach (var prop in props)
            {
                var param = prop.GetCustomAttribute<ApiParameterAttribute>();
                var value = prop.GetValue(props, null) as string;

                // TODO: Move to model validator
                if (value.IsNullOrEmpty())
                {
                    if (Attribute.IsDefined(prop.GetType(), typeof(RequiredAttribute)))
                    {
                        // TODO: Create custom exception
                        throw new ArgumentNullException(prop.Name);
                    }

                    continue;
                }

                switch (param.ParameterType)
                {
                    case ParameterType.NotSet:
                        // TODO: Create custom exception
                        throw new ArgumentException(param.Name);
                    case ParameterType.Header:
                        headers.Add(param.Name, value);
                        break;
                    case ParameterType.Query:
                        query.Add(param.Name, value);
                        break;
                    case ParameterType.Path:
                        path.Add(param.Name, value);
                        break;
                    case ParameterType.JsonBody:
                        body.Add(param.Name, value);
                        break;
                    case ParameterType.Version:
                        version = value;
                        break;
                }
            }

            return new ApiParameter
            {
                Headers = headers,
                QueryParameters = query,
                PathParameters = path,
                Version = version,
                JsonBody = body
            };
        }
    }
}