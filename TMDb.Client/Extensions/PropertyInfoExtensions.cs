using System;
using System.Reflection;

namespace TMDb.Client.Extensions
{
    public static class PropertyInfoExtensions
    {
        public static bool HasAttribute<T>(this PropertyInfo propertyInfo) =>
            Attribute.IsDefined(propertyInfo, typeof(T));
    }
}