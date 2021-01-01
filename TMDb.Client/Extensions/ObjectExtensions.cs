using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TMDb.Client
{
    public static class ObjectExtensions
    {
        public static string ToQueryString(this object @object)
        {
            var parameters = @object.GetType()
                .GetProperties()
                .Where(x => x.GetValue(@object, null) != null)
                .Select(x => string.Format("{0}={1}", PropertyName(x), x.Get(@object))) //x.UrlEncode
                .ToArray();

            return parameters.Any() ? "?" + string.Join("&", parameters) : null;
        }

        private static string PropertyName(this PropertyInfo propertyInfo) =>
            propertyInfo.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? propertyInfo.Name;

        private static object Get(this PropertyInfo property, object @object)
        {
            var value = property.GetValue(@object, null);

            if (value.GetType().BaseType == typeof(Enum))
            {
                var description = value.GetType()
                                       .GetMember(value.ToString())
                                       .FirstOrDefault()?
                                       .GetCustomAttribute<DescriptionAttribute>()?
                                       .Description;

                if (description.HasValue())
                    return description;
            }

            return value;
        }

        private static string UrlEncode(this PropertyInfo propertyInfo, object @object) =>
            HttpUtility.UrlEncode(propertyInfo.GetValue(@object, null).ToString());
    }
}