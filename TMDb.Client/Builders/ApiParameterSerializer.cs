using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using TMDb.Client.Api;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;
using TMDb.Client.Extensions;
using TMDb.Client.Models;

namespace TMDb.Client.Builders
{
    public class ApiParameterSerializer : IApiParameterSerializer
    {
        // TODO: Split out each serializer option into their own methods to make it easier to read
        public ApiParameter SerializeRequestParameters(RequestBase request)
        {
            //var validation = new ValidationContext(request);
            //Validator.ValidateObject(request, validation);

            var requestProperties = request.GetType().GetProperties();
            var props = requestProperties.Where(x => x.HasAttribute<ApiParameterAttribute>());

            var parameters = new ApiParameter();

            foreach (var prop in props)
            {
                var param = prop.GetCustomAttribute<ApiParameterAttribute>();
                var value = prop.GetValue(request);

                // TODO: #1 refactor out validation
                if (value == null)
                {
                    var test1 = prop.GetCustomAttribute<RequiredAttribute>();

                    // TODO: Move required validation to custom model validator
                    if (prop.HasAttribute<RequiredAttribute>())
                    {
                        // TODO: Create custom exception
                        throw new ArgumentNullException(prop.Name);
                    }
                }
                else
                {
                    //if (prop.HasAttribute<RangeAttribute>())
                    //{
                    //    var range = prop.GetCustomAttribute<RangeAttribute>();
                    //    var number = (double)value;
                    //    if (value is double @double)
                    //    {
                    //        Validator
                    //    }
                    //    else if (value is int @int)
                    //    {
                    //    }
                    //    if (number < range.Minimum || number > range.Maximum)
                    //    {
                    //        throw new ArgumentOutOfRangeException(prop.Name);
                    //    }
                    //}

                    var paramValue = default(string);

                    if (param.Option == SerializationOption.NotSet)
                    {
                        paramValue = value.ToString();
                    }
                    else if (param.Option == SerializationOption.Delimeter)
                    {
                        var delimeter = ",";

                        var delimeterEnum = requestProperties.Where(x => x.Name.Equals(param.Delimeter))
                                                                 .SingleOrDefault()
                                                                 .GetValue(request);

                        if (delimeterEnum is Delimeter delimeterValue)
                        {
                            if (delimeterValue == Delimeter.Or)
                            {
                                delimeter = "|";
                            }
                        }
                        else
                        {
                            // TODO: Create custom exception
                            throw new NullReferenceException($"{prop.Name} {nameof(DescriptionAttribute)}");
                        }

                        if (prop.PropertyType == typeof(IEnumerable<MovieReleaseType>))
                        {
                            var collection = (IEnumerable<MovieReleaseType>)value;
                            paramValue = string.Join(delimeter, collection.Select(x => (int)x));
                        }
                        else if (prop.PropertyType == typeof(IEnumerable<int>))
                        {
                            var collection = (IEnumerable<int>)value;
                            paramValue = string.Join(delimeter, collection.Select(x => x.ToString()));
                        }
                        else
                        {
                            // TODO: Create custom exception
                            throw new NotImplementedException($"{request.GetType().Name} {prop.Name} :: SerializationOption.Delimeter is not implemented for type {prop.PropertyType.Name}");
                        }
                    }
                    else if (param.Option == SerializationOption.DateOnly)
                    {
                        if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                        {
                            var date = (DateTime)value;
                            paramValue = date.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            // TODO: Create custom exception
                            throw new ArgumentException($"{request.GetType().Name} {prop.Name}");
                        }
                    }
                    else if (param.Option == SerializationOption.EnumDescription)
                    {
                        // TODO: This blows up when enum prop type is nullable 
                        // but the instance reference does have a value
                        var enumDescription = prop.PropertyType
                                                  .GetField(value.ToString())
                                                  .GetCustomAttribute<DescriptionAttribute>();

                        if (enumDescription == null)
                        {
                            throw new NullReferenceException($"{prop.Name} {nameof(DescriptionAttribute)}");
                        }

                        paramValue = enumDescription.Description;
                    }
                    else if (param.Option == SerializationOption.NoHyphen)
                    {
                        if (prop.PropertyType == typeof(Guid?) || prop.PropertyType == typeof(Guid))
                        {
                            var guid = (Guid)value;
                            paramValue = guid.ToString("N");
                        }
                        else
                        {
                            // TODO: Create custom exception
                            throw new NotImplementedException($"{request.GetType().Name} {prop.Name} :: SerializationOption.NoHyphen is not implemented for type {prop.PropertyType.Name}");
                        }
                    }
                    else if (param.Option == SerializationOption.ToLower)
                    {
                        paramValue = value.ToString().ToLowerInvariant();
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

        private static IApiParameterSerializer _instance;
        public static IApiParameterSerializer Instance =
            _instance = _instance ?? new ApiParameterSerializer();
    }
}