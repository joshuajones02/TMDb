using System;
using System.Reflection;
using TMDb.Client.Attributes;

namespace TMDb.Client.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static bool HasAttribute<T>(this PropertyInfo propertyInfo) =>
            Attribute.IsDefined(propertyInfo, typeof(ApiParameterAttribute));
    }
}