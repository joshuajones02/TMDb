using System;

namespace TMDb.Client.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ApiParameterIgnoreAttribute : Attribute
    {
    }
}