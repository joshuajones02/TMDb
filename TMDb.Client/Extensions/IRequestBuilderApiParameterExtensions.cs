using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using TMDb.Client.Api;
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
            var query = new Dictionary<string, string>();
            var path = new Dictionary<string, string>();
            var body = new Dictionary<string, string>();
            var version = default(string);

            var props = request.GetType()
                .GetProperties()
                //.Where(x => x.HasAttribute<ApiParameterAttribute>()));
                .Where(x => Attribute.IsDefined(x, typeof(ApiParameterAttribute)));

            foreach (var prop in props)
            {
                var param = prop.GetCustomAttribute<ApiParameterAttribute>();
                var value = prop.GetValue(request);

                // TODO: Move to model validator
                if (value == null)
                {
                    if (Attribute.IsDefined(prop.GetType(), typeof(RequiredAttribute)))
                    {
                        // TOD-O: Create custom exception
                        throw new ArgumentNullException(prop.Name);
                    }

                    continue;
                }

                var paramValue = default(string);

                if (param.Option == SerializationOption.NotSet)
                {
                    paramValue = value.ToString();
                }
                else if (param.Option == SerializationOption.DateOnly)
                {
                    if (prop.PropertyType == typeof(DateTime?))
                    {
                        var date = (DateTime?)value;
                        paramValue = date.Value.ToString("yyyy-MM-dd");
                    }
                    else if (prop.PropertyType == typeof(DateTime))
                    {
                        var date = (DateTime)value;
                        paramValue = date.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        throw new ArgumentException($"{request.GetType().Name} {prop.Name}");
                    }
                }

                // NOTE: !!! DO NOT COMMIT - this is temp 
                if (paramValue.IsNullOrEmpty())
                {
                    System.Diagnostics.Trace.TraceError($"VALUE NOT SET BUT GOT BY SOMEHOW ==> {request.GetType().Name} {prop.Name}");
                    throw new ArgumentNullException($"{request.GetType().Name} {prop.Name}");
                }

                switch (param.ParameterType)
                {
                    case ParameterType.NotSet:
                        // TODO: Create custom exception
                        throw new ArgumentException(param.Name);
                    case ParameterType.Header:
                        headers.Add(param.Name, paramValue);
                        break;
                    case ParameterType.Query:
                        query.Add(param.Name, paramValue);
                        break;
                    case ParameterType.Path:
                        path.Add(param.Name, paramValue);
                        break;
                    case ParameterType.JsonBody:
                        body.Add(param.Name, paramValue);
                        break;
                    case ParameterType.Version:
                        version = paramValue;
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