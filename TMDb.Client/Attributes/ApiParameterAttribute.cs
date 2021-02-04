using System;

namespace TMDb.Client.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ApiParameterAttribute : Attribute
    {
        public string Delimeter { get; set; }
        public string Name { get; set; }
        public ParameterType ParameterType { get; set; }
        public SerializationOption Option { get; set; }
    }
}