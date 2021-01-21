using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using TMDb.Client.API;
using TMDb.Client.Attributes;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public class RequestBuilder : IRequestBuilder
    {
        public ApiEndpoint GetApiEndpoint(RequestBase request)
        {
            var endpoint = request.GetType()
                .GetCustomAttributes(inherit: true)
                .Single(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                          || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute)))
                .CastType<ApiEndpointAttribute>();

            return new ApiEndpoint
            {
                Path = endpoint.Path,
                HttpMethod = endpoint.HttpMethod
            };
        }

        public List<ApiParameter> GetApiParameters(RequestBase request)
        {
            var apiParameters = new List<ApiParameter>();
            var members = request.GetType()
                .GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(x => x.MemberType == MemberTypes.Field || x.MemberType == MemberTypes.Property);

            foreach (MemberInfo member in members)
            {
                var attr = member.GetCustomAttribute<ApiParameterAttribute>(inherit: true);

                if (attr == null)
                {
                    var message = string.Format("Property {0} of {1} missing required attribute {2}",
                        member.Name, request.GetType().Name, nameof(ApiParameterAttribute));

                    // TODO: Create custom exception
                    throw new ArgumentNullException(member.Name, message);
                }

                var value = request.GetType().GetProperty(member.Name).GetValue(request, null);

                if (value != null)
                {
                    apiParameters.Add(new ApiParameter(attr.Name, attr.ParameterType, value.ToString()));
                }
                else
                {
                    if (member.GetCustomAttribute<RequiredAttribute>(inherit: true) != null)
                        throw new ArgumentNullException(member.Name);
                }
            }

            return apiParameters;
        }

        public static IRequestBuilder _instance;

        public static IRequestBuilder Instance =>
            _instance = _instance ?? new RequestBuilder();
    }
}