using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using TMDb.Client.Api;
using TMDb.Client.Attributes;
using TMDb.Client.Builders;
using TMDb.Client.Models;

namespace TMDb.Client.Extensions
{
    public static class IRequestBuilderApiParameterExtensions
    {
        private static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            DescriptionAttribute attribute
                    = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute))
                        as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static ApiParameter SerializeRequestParameters(this IRequestBuilder builder, RequestBase request)
        {
            var props = request.GetType()
                               .GetProperties()
                               .Where(x => x.HasAttribute<ApiParameterAttribute>());

            var parameters = new ApiParameter();

            foreach (var prop in props)
            {
                var param = prop.GetCustomAttribute<ApiParameterAttribute>();
                var value = prop.GetValue(request);

                if (value == null)
                {
                    var test1 = prop.GetCustomAttribute<RequiredAttribute>();

                    // TODO: Move required validation to custom model validator
                    if (prop.HasAttribute<RequiredAttribute>())
                    {
                        // TOD-O: Create custom exception
                        throw new ArgumentNullException(prop.Name);
                    }
                }
                else
                {
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
                    else if (param.Option == SerializationOption.EnumDescription)
                    {
                        var enumDescription = prop.GetCustomAttribute<DescriptionAttribute>();

                        if (enumDescription == null)
                        {
                            throw new NullReferenceException($"{prop.Name} {nameof(DescriptionAttribute)}");
                        }
                    }
                    else
                    {
                        // TODO: Create custom exception
                        throw new ArgumentException($"{request.GetType().Name} {prop.Name}");
                    }

                    switch (param.ParameterType)
                    {
                        case ParameterType.NotSet:
                            // TODO: Create custom exception
                            throw new ArgumentException(param.Name);
                        case ParameterType.Header:
                            parameters.Headers.Add(param.Name, paramValue);
                            break;
                        case ParameterType.Query:
                            parameters.QueryParameters.Add(param.Name, paramValue);
                            break;
                        case ParameterType.Path:
                            parameters.PathParameters.Add(param.Name, paramValue);
                            break;
                        case ParameterType.JsonBody:
                            parameters.JsonBody.Add(param.Name, paramValue);
                            break;
                        case ParameterType.Version:
                            parameters.Version = paramValue;
                            break;
                    }
                }
            }

            return parameters;
        }
    }
}