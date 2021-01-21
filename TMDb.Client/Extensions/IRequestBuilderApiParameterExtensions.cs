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
        public static List<ApiParameter> GetApiParameters(this IRequestBuilder builder, RequestBase request)
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
    }
}